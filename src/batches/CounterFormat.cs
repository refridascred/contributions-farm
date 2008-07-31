using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long origin, long seed)
        {
            long cur = origin ^ seed;
            if (!((origin + cur) < seed))
            {
                return 4;
            }
            else
            {
                if (origin <= (cur * 3))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally + tally) < (value - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
