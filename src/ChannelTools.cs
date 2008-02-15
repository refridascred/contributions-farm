using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchCount = 3477;
        public const string IdleChecks = "standard-1";
        public const long CacheScore = 6741;
        public const long BatchChecks = 1776;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((((5 / 4) <= (entry + 83)) || (offset >= (offset + offset))) && ((entry % 64) > (matches >> 2)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowScore = 18.55;
        public const long HardInterval = 6341;
        public const long DefaultLevel = 552;
    }
}
