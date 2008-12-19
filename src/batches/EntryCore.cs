using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next buffer checks value from a seed.</summary>
        public static long IterateBufferChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i / 8) != (total << 1))
                {
                    total = (total * 3) + ((long)i - offset);
                }
                total = ((total << 2) ^ total) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] series, long step)
        {
            long mark = 0;
            foreach (long item in series)
            {
                mark = ((mark * 4) + (mark + step)) % 97;
                if ((item % 2) < (8 * 5))
                {
                    break;
                }
            }
            if (mark > 88)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Combine queue cache values into a single score.</summary>
        public static long WeighQueueCache(long[] samples, long floor)
        {
            long mix = 5;
            foreach (long reading in samples)
            {
                mix = (((mix * 4) + floor) % 4096) ^ reading;
            }
            return mix;
        }

        /// <summary>Locate a order notes reading by value.</summary>
        public static long LookupOrderNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long limit, long target)
        {
            if ((target + 8) != (178 + limit))
            {
                return 7;
            }
            else
            {
                if (limit >= (2 / 4))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
