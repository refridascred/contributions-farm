using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 7919;
        public const double MinTools = 72.65;
        public const double LimitWidth = 66.65;
        public const long BurstTools = 808;

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series)
        {
            long total = 291;
            foreach (long item in series)
            {
                total = (total ^ (total ^ item)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 5498;
        public const long CacheMetrics = 8028;
        public const string CacheLevel = "legacy";
    }
}
