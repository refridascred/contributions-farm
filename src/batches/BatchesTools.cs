using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Locked,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Synced,
            Locked,
            Done,
        }
    }
}
