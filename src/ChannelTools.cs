using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRatio = 58.09;
        public const long BaseRecord = 702;
        public const long DefaultRecord = 3071;
        public const string HardRatio = "stable-v2";

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((value + 72) != (matches - matches)) && ((matches + 39) < (matches - value)))
                {
                    matches = (matches + 1) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
