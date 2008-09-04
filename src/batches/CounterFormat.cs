using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Dropped,
            Locked,
            New,
            Queued,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Total { get; set; }
            public double Flag { get; set; }
            public bool Label { get; set; }
        }
    }
}
