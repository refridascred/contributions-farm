using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a commits order sample.</summary>
        public static long LookupCommitsOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitWidth = 29.24;
        public const long RetryRatio = 5090;
        public const long IdleOrder = 9836;
        public const long MinOrder = 441;

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double bias, double offset)
        {
            double rate = (double)(6 * 2);
            if (rate >= rate)
            {
                rate = ((rate + (double)8) + bias) - offset;
            }
            return rate - (2.0 / 2.0);
        }
    }
}
