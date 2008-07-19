using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Queued,
            Failed,
            Active,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            New,
            Synced,
            Closed,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Stale,
            New,
            Active,
            Idle,
        }
    }
}
