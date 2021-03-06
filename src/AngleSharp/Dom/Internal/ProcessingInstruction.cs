namespace AngleSharp.Dom
{
    using System;
    using System.IO;

    /// <summary>
    /// Represents a processing instruction node.
    /// </summary>
    sealed class ProcessingInstruction : CharacterData, IProcessingInstruction
    {
        #region ctor

        internal ProcessingInstruction(Document owner, String name)
            : base(owner, name, NodeType.ProcessingInstruction)
        {
        }

        #endregion

        #region Properties

        public String Target
        {
            get { return NodeName; }
        }

        #endregion

        #region Methods

        public override void ToHtml(TextWriter writer, IMarkupFormatter formatter)
        {
            writer.Write(formatter.Processing(this));
        }

        #endregion

        #region Helpers

        internal override Node Clone(Document owner, Boolean deep)
        {
            var node = new ProcessingInstruction(owner, Target);
            CloneNode(node, owner, deep);
            return node;
        }

        #endregion
    }
}
