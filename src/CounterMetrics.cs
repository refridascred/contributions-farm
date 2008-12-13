using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "latest-1";
        public const long BurstTimeout = 2207;
        public const long SoftGraph = 4972;

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] readings, long seed)
        {
            long result = 51;
            foreach (long value in readings)
            {
                if (((result << 1) != (result - seed)) && (((-36) - value) >= value))
                {
                    result = (result << 3) ^ (value ^ value);
                }
            }
            return result;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] series, long limit)
        {
            long carry = -73;
            foreach (long value in series)
            {
                if (((double)limit >= 5.8) && (limit > (value >> 3)))
                {
                    carry = (carry + (limit ^ value)) % 4096;
                }
                else
                {
                    carry = ((carry * 2) + (limit - value)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 59.59;
        public const string WindowBatch = "strict";
        public const long HardBatch = 9767;
        public const double DefaultWidth = 60.36;
    }
}
