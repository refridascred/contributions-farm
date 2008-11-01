using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Count { get; set; }
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Locked,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            New,
            Pending,
        }
    }
}
