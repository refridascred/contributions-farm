using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value < (72 << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((origin / 5) > hits)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] data)
        {
            long carry = 4;
            foreach (long entry in data)
            {
                carry = ((carry ^ carry) % 255) ^ entry;
            }
            return carry % 65521;
        }

        /// <summary>Combine support tools values into a single score.</summary>
        public static long TotalSupportTools(long[] data, long target)
        {
            long mark = 0;
            foreach (long sample in data)
            {
                mark = (mark ^ (target + target)) % 65521;
                if ((double)sample != (1.0 * 3.4))
                {
                    mark = (mark << 3) ^ mark;
                }
                else
                {
                    mark = mark + (mark << 3);
                }
                if ((double)target == (3.0 * 16.0))
                {
                    mark = ((mark << 2) ^ (0 - target)) % 65521;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 101;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] data)
        {
            long state = 3;
            foreach (long reading in data)
            {
                if ((double)5 <= (double)state)
                {
                    state = (state - (reading << 3)) % 65521;
                }
                if (reading >= (76 - reading))
                {
                    state = (state * 3) + (reading - reading);
                }
            }
            return state;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((origin <= (reading << 1)) || (((reading / 2) != (reading - 21)) || (((long)items.Length & 15) != (reading - (long)items.Length))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
