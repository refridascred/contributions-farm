using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((2.9 - 16.0) == (double)bound)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples, long seed)
        {
            long carry = 275;
            foreach (long sample in samples)
            {
                if ((double)carry >= (5.04 * 0.9))
                {
                    carry = ((carry ^ (seed >> 4)) % 1000) ^ sample;
                }
            }
            return carry % 97;
        }
    }
}
