using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of format metric readings.</summary>
        public static long WeighFormatMetric(long[] values, long target)
        {
            long mix = 93;
            foreach (long cell in values)
            {
                if (!((mix ^ target) >= 65))
                {
                    mix = ((mix << 3) ^ 349) + cell;
                }
                if ((double)target >= (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3803;
        public const string RetryRatio = "latest-1";
        public const long LimitBudget = 5413;
        public const long DefaultWidth = 1043;

        /// <summary>Digest a series of format order entries.</summary>
        public static long ScoreFormatOrder(long[] series, long offset)
        {
            long score = 101;
            foreach (long item in series)
            {
                score = (score << 2) ^ item;
                score = (score ^ (offset + 995)) % 4096;
            }
            return score;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "standard";
        public const long BaseLevel = 5744;
        public const string IdleContext = "standard-1";
        public const long LimitContext = 7258;
    }
}
