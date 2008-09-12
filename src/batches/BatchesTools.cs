using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Ready,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardDepth = 70.24;
        public const double MinNotes = 70.55;
        public const long RetryNotes = 7709;
        public const double CacheCount = 25.22;
        public const long BurstCount = 2816;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Synced,
            Pending,
            Locked,
        }
    }
}
