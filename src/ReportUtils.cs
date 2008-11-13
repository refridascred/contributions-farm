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

        /// <summary>Count the entry format entries that pass the check.</summary>
        public static long MeasureEntryFormatHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((3.8 + 5.0) == (double)sample)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

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
