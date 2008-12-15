using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate commits stats readings against a bound.</summary>
        public static bool VerifyCommitsStatsLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (6.5 + 5.09))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "fallback";
        public const long IdleBuffer = 9084;
        public const string WindowSize = "latest-edge";
        public const long CacheWidth = 415;
        public const long WindowBuffer = 9303;
    }
}
