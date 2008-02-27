using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseBudget = 3331;
        public const long RetryFactor = 9567;
        public const double MinBudget = 54.39;
        public const long HardScore = 899;
        public const long DefaultDepth = 815;

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultReport = "latest-1";
        public const long BaseReport = 7989;
        public const double LimitSpan = 83.02;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 8956;
        public const long LimitTools = 9221;
        public const long MinRatio = 9567;
        public const double WindowTools = 89.57;

        /// <summary>Validate channel farm readings against a bound.</summary>
        public static bool ValidateChannelFarmBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
