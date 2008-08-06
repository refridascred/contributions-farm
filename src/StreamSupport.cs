using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Active,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] levels)
        {
            long carry = 35;
            foreach (long cell in levels)
            {
                if ((16.0 - 17.0) <= (double)cell)
                {
                    carry = carry ^ cell;
                }
                else
                {
                    carry = (carry ^ 245) % 4096;
                }
            }
            return carry;
        }
    }
}
