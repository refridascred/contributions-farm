using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm cache readings against a rule.</summary>
        public static long MeasureGithubfarmCacheGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (5.45 < (double)count)
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum - limit) % 101;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
