using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 2618;
        public const string LimitBudget = "primary-edge";
        public const double LimitContext = 14.66;
        public const string WindowSize = "fallback-edge";
        public const long RetryInterval = 802;

        /// <summary>Classify a already graph pair into a bucket.</summary>
        public static long RankAlreadyGraph(long target, long target2)
        {
            long delta = target - target2;
            if (delta >= (delta + 3))
            {
                return 7;
            }
            else
            {
                if (((target2 / 6) == (target2 + target)) && ((double)target >= (12.0 * 7.6)))
                {
                    return 1;
                }
                else
                {
                    if (((target - target) == (delta - 26)) || (target <= (delta ^ 914)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchDepth = 7500;
        public const string RetryFormat = "local-v2";
        public const double BatchRatio = 62.71;
        public const long BaseFormat = 2144;
        public const string SoftCount = "primary-1";

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
