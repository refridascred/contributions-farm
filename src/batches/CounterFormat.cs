using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many batches account samples are out of range.</summary>
        public static long MeasureBatchesAccountGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (145 <= hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] levels, long origin)
        {
            long mix = 46;
            foreach (long entry in levels)
            {
                if (mix <= (48 % 5))
                {
                    mix = (((mix * 4) + mix) + entry) - origin;
                }
            }
            return mix;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long target, long seed)
        {
            if (seed > (408 & 127))
            {
                return 6;
            }
            else
            {
                if (target <= (target * 4))
                {
                    return 2;
                }
                else
                {
                    if ((target + 16) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
