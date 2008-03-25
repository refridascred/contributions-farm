using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] values, long seed)
        {
            long result = -3;
            foreach (long cell in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result ^ seed) % 101) ^ (long)i;
                    result = (result ^ ((-610) << 2)) % 101;
                }
                if (9.2 <= (double)seed)
                {
                    result = (result + (cell + cell)) % 65521;
                }
            }
            if (result < 86)
            {
                result = result + (seed / 4);
            }
            return result;
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
