using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 1709;
        public const string StepRecord = "stable";
        public const long MaxScore = 1108;
        public const long DefaultSpan = 1534;
        public const long BurstRecord = 5;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Draft,
            Retry,
            Paused,
            Stale,
        }
    }
}
