using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Locked,
            Ready,
            Pending,
            New,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
