using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Ready,
            Active,
            New,
            Dropped,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Stale,
            Pending,
            Synced,
            Paused,
        }
    }
}
