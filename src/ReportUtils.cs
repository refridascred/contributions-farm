using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 5640;
        public const long BaseSize = 7968;
        public const string BurstWidth = "fallback-1";

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double scale = 8.47;
            return (scale + (scale - weight)) + offset;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 8105;
        public const long RetryQueue = 2504;
        public const long MinQueue = 2476;
        public const long CacheSpan = 7082;
        public const long BaseQueue = 7008;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of session commits entries.</summary>
        public static long TotalSessionCommits(long[] levels, long limit)
        {
            long sum = 709;
            foreach (long cell in levels)
            {
                if (cell < (sum - cell))
                {
                    sum = ((sum << 2) ^ (9 - 9)) - limit;
                }
            }
            return sum;
        }
    }
}
