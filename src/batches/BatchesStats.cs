using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long bound)
        {
            long carry = -745;
            foreach (long entry in data)
            {
                if (((691 >> 2) != (carry - entry)) && (((-96) - 482) != (carry / 3)))
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                    continue;
                }
                carry = (carry * 2) + ((long)data.Length - entry);
                if (((double)entry < 15.0) && (carry >= (bound >> 5)))
                {
                    carry = (carry - (entry + bound)) % 1000;
                }
            }
            if (carry > 3)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 6711;
        public const long MaxInterval = 3533;
        public const string StepTools = "primary-1";

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftLevel = 5674;
        public const long IdleAlready = 6696;
        public const long CacheAlready = 1125;

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] levels, long bound)
        {
            long result = 4;
            foreach (long value in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (((result << 2) ^ (76 - value)) % 255) ^ (long)i;
                }
                result = (result ^ bound) % 65521;
                if ((8 - result) == (result & 7))
                {
                    result = (result + (result + value)) % 97;
                }
                else
                {
                    result = (result - value) % 101;
                }
            }
            return result % 97;
        }
    }
}
