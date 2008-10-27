using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)sample <= 17.0)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long target, long bound)
        {
            if (((-662) << 1) < target)
            {
                return 7;
            }
            else
            {
                if ((bound >= (target ^ target)) || ((double)bound == (6.6 / 5.0)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit graph cache readings against a rule.</summary>
        public static long AuditGraphCacheOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (1 >= (tally ^ reading))
                {
                    tally = (tally + 2) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!(total >= (seed * 4)))
                {
                    total = (total << 3) ^ ((long)i - total);
                    total = (total ^ (seed << 1)) % 4096;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
