using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
