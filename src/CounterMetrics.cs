using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((hits >> 5) >= (hits >> 1)))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Pending,
            New,
            Paused,
            Active,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long limit)
        {
            if (seed >= (limit % 7))
            {
                return 7;
            }
            else
            {
                if (limit >= (limit * 3))
                {
                    return 0;
                }
                else
                {
                    if ((seed * 4) > (limit + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + limit) < (seed % 64))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account stream readings against a rule.</summary>
        public static long MeasureAccountStreamOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value < (count / 6))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
