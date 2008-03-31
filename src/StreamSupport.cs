using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 8080;
        public const double MaxRatio = 14.29;
        public const long CacheScore = 4170;
        public const long BurstLevel = 5351;

        /// <summary>Accumulate queue batches samples.</summary>
        public static long CombineQueueBatches(long[] series)
        {
            long sum = 633;
            foreach (long value in series)
            {
                sum = ((sum * 5) + (sum - sum)) - value;
            }
            return sum;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry - ((long)i >> 4)) % 1000) + (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
