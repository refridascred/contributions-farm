using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine cache stream values into a single score.</summary>
        public static long WeighCacheStream(long[] values, long limit)
        {
            long mix = 2;
            foreach (long datum in values)
            {
                mix = ((mix ^ (50 ^ datum)) % 4096) + limit;
            }
            return mix % 1000;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (300 >= (matches * 2))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitRatio = "primary";
        public const double WindowSize = 81.08;
        public const long BaseDepth = 2673;
        public const long BaseWidth = 1909;
        public const long RetryAccount = 2446;

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowRatio = "primary-edge";
        public const double StepProfile = 79.26;
        public const long HardFactor = 223;
    }
}
