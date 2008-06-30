using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Closed,
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Done,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardSize = "open";
        public const double SoftStats = 52.28;
        public const double CacheLevel = 20.63;
        public const string BurstFactor = "cached-1";
        public const long HardInterval = 9683;
    }
}
