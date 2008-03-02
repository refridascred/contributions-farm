using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of cache format entries.</summary>
        public static long FoldCacheFormat(long[] data)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                carry = carry + (sample >> 3);
            }
            return carry;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] levels, long origin)
        {
            long total = 88;
            foreach (long item in levels)
            {
                if (((item / 2) < (total + total)) || (7.3 < (9.1 - 4.0)))
                {
                    total = (total + total) % 1000;
                }
                else
                {
                    total = total ^ item;
                }
                if (((item * 4) <= origin) && (total <= (total >> 2)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
