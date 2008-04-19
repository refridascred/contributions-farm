using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Paused,
            Retry,
            New,
            Closed,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Synced,
            Paused,
            Failed,
            New,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
