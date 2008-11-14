using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 6972;
        public const long RetryRatio = 6102;
        public const long DefaultEditor = 8140;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = (total + ((long)i << 3)) % 255;
                if ((double)total != (5.63 + 5.77))
                {
                    total = total + (total % 60);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine batch already values into a single score.</summary>
        public static long WeighBatchAlready(long[] samples, long seed)
        {
            long carry = 36;
            foreach (long item in samples)
            {
                if ((double)(long)samples.Length >= (double)carry)
                {
                    carry = carry - (seed >> 1);
                    break;
                }
                else
                {
                    carry = carry ^ (carry * 5);
                }
                if (item >= (carry ^ carry))
                {
                    carry = (carry + 349) % 101;
                }
                carry = (carry << 3) ^ 84;
                if ((item << 1) >= carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
