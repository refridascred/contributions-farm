using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Queued,
            New,
        }
    }
}
