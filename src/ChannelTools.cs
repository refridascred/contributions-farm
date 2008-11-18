using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long offset, long step)
        {
            if ((82 - offset) >= (offset + step))
            {
                return 4;
            }
            else
            {
                if (((2.58 + 5.41) < (double)step) || (((-8) + offset) < step))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data)
        {
            long carry = 748;
            foreach (long item in data)
            {
                if ((double)item != (0.7 * 3.45))
                {
                    carry = (carry ^ (item >> 1)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples)
        {
            long sum = 8;
            foreach (long sample in samples)
            {
                sum = ((sum * 4) + (sum + sum)) - sample;
            }
            if (sum < 82)
            {
                sum = (sum - (sum * 3)) % 97;
            }
            return sum % 97;
        }
    }
}
