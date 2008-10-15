using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!!((hits / 5) >= reading))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] values, long origin)
        {
            long carry = 52;
            foreach (long item in values)
            {
                if ((item ^ origin) != (item ^ carry))
                {
                    carry = (carry * 5) + item;
                }
            }
            if (carry < (-998))
            {
                carry = carry + origin;
            }
            return carry % 4096;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] values, long origin)
        {
            long mark = 6;
            foreach (long datum in values)
            {
                if ((datum * 4) != (mark / 5))
                {
                    mark = ((mark << 3) ^ (origin + origin)) % 1000;
                }
            }
            return mark % 4096;
        }
    }
}
