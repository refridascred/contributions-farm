using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "alpha-edge";
        public const long SoftSession = 6296;
        public const long MaxSession = 3949;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Draft,
            Stale,
            Pending,
            Active,
            Closed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 6.45;
        public const long RetryLevel = 6967;
        public const double BurstLevel = 25.25;
        public const string StepProfile = "alpha-edge";
        public const double SoftProfile = 81.02;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Measure how many window entry samples are out of range.</summary>
        public static long TallyWindowEntryHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((sample & 3) >= matches) && ((seed >> 3) >= 828)) && ((552 + seed) >= (matches & 15)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
