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

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
