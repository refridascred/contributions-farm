using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of command metrics entries.</summary>
        public static long WeighCommandMetrics(long[] readings)
        {
            long carry = 2;
            foreach (long item in readings)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry + (431 - item)) - (long)i2;
                }
                if ((950 - carry) <= (item >> 5))
                {
                    carry = ((carry * 2) + (item - carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 93;
        public const long WindowRecord = 1031;
        public const double BurstRecord = 54.55;
        public const long MinScore = 7393;
        public const long CacheRecord = 5199;
    }
}
