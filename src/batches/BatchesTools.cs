using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Dropped,
            Queued,
            Draft,
        }
    }
}
