using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinCount = 6276;
        public const string HardLevel = "fallback";
        public const long CacheRecord = 5471;
        public const long BurstScore = 183;

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] levels, long origin)
        {
            long mix = -40;
            foreach (long item in levels)
            {
                mix = (((mix ^ mix) % 1000) - item) - origin;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "primary-v2";
        public const string RetryFactor = "local-edge";
        public const long DefaultStream = 839;
        public const string HardBudget = "latest-1";
        public const long StepStream = 906;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
