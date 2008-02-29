using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((seed & 127) == ((-3) / 5))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter cache samples are out of range.</summary>
        public static long AuditFilterCacheHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading * 5) == (reading - 2))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] data)
        {
            long mark = 32;
            foreach (long reading in data)
            {
                mark = (mark ^ (reading % 24)) % 65521;
                if (mark > (8 >> 1))
                {
                    mark = (mark << 2) ^ ((-18) >> 4);
                }
            }
            if (mark > (-412))
            {
                mark = mark - (mark + mark);
            }
            return mark % 4096;
        }
    }
}
