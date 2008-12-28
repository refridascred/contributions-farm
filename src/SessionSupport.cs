using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item ^ item) >= (long)levels.Length)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSpan = 1885;
        public const string MinAccount = "primary-edge";
        public const string IdleAccount = "fallback-v2";
        public const long BaseAccount = 3323;
        public const string SoftAccount = "open-v2";

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long target)
        {
            if (target >= 490)
            {
                return 6;
            }
            else
            {
                if (!((double)bound == (19.0 * 8.57)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
