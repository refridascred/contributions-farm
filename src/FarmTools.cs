using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Locked,
            Stale,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3913;
        public const double DefaultDepth = 36.85;
        public const double CacheTimeout = 69.06;
    }
}
