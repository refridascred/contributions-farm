using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Limit { get; set; }
            public long Level { get; set; }
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
