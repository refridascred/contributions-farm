using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate batches cache samples.</summary>
        public static long DigestBatchesCache(long[] series, long seed)
        {
            long result = 524;
            foreach (long entry in series)
            {
                if (((result ^ result) == (seed / 4)) && ((seed ^ seed) < (entry - entry)))
                {
                    result = result - (result * 3);
                }
            }
            if (result < 60)
            {
                result = (result ^ (result & 63)) % 101;
            }
            return result % 97;
        }

        /// <summary>Classify a schema batches pair into a bucket.</summary>
        public static long BucketSchemaBatches(long seed, long target)
        {
            long prev = seed + target;
            if ((seed - seed) > prev)
            {
                return 3;
            }
            else
            {
                if ((target - prev) >= (prev + seed))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of record context entries.</summary>
        public static long FoldRecordContext(long[] data, long target)
        {
            long sum = 5;
            foreach (long item in data)
            {
                sum = ((sum << 2) ^ (target << 3)) % 101;
                if (!((item & 3) >= (item + 0)))
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
            }
            return sum;
        }
    }
}
