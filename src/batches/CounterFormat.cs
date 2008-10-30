using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Active,
            New,
        }
    }
}
