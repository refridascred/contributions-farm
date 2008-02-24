using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            New,
            Ready,
            Stale,
            Idle,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Failed,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }
    }
}
