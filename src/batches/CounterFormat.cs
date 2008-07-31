using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
