using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSpan = 2841;
        public const long DefaultInterval = 4571;
        public const string BurstWindow = "open-v2";
        public const long StepBudget = 7760;
        public const long CacheSize = 2096;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxSpan = "alpha-v2";
        public const double LimitMetrics = 12.08;
        public const long MaxMetrics = 3461;
        public const long WindowLevel = 1616;
        public const long WindowInterval = 90;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "latest-edge";
        public const long StepChecks = 2401;
        public const long HardChecks = 72;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Idle,
            Queued,
            Ready,
            Dropped,
        }

        /// <summary>Rank cluster support input into a small class.</summary>
        public static long ClassifyClusterSupport(long origin, long floor)
        {
            if ((origin - origin) >= (8 >> 1))
            {
                return 3;
            }
            else
            {
                if ((origin & 127) <= 12)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
