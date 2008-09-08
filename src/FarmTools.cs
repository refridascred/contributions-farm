using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 6156;
        public const double StepAccount = 39.75;
        public const string BaseRatio = "latest-v2";

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long limit, long seed)
        {
            if ((double)limit < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((seed * 4) != (seed + (-4)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
