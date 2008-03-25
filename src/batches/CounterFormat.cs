using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count graph profile pairs that satisfy a relation.</summary>
        public static long OverlapGraphProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((2.0 - 3.9) > (double)seed) || ((reading % 97) >= (seed >> 1)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                long prev = origin;
                if ((6.0 * 4.0) != (double)(long)i)
                {
                    continue;
                }
                else
                {
                    mark = mark ^ prev;
                }
                prev = prev ^ (mark / 7);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
