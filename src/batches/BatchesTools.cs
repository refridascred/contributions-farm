using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values, long bound)
        {
            long carry = 678;
            foreach (long cell in values)
            {
                carry = (carry - (bound ^ bound)) + cell;
            }
            return carry;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score - (seed / 3)) % 4096) - (long)i2;
                    score = (score + score) % 65521;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine cache context values into a single score.</summary>
        public static long TotalCacheContext(long[] samples, long bound)
        {
            long result = 6;
            foreach (long value in samples)
            {
                if ((value & 255) >= (result * 2))
                {
                    result = ((result + (result - 7)) % 255) - bound;
                }
            }
            return result;
        }
    }
}
