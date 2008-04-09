using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryLevel = 3094;
        public const long BatchTimeout = 5078;
        public const string MaxOrder = "latest-edge";

        /// <summary>Accumulate command cache samples.</summary>
        public static long WeighCommandCache(long[] readings, long origin)
        {
            long carry = 2;
            foreach (long item in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry << 3) ^ ((long)i + carry)) + origin;
                }
                carry = ((carry * 3) + (item % 3)) % 101;
            }
            if (carry < 99)
            {
                carry = (carry * 5) + (carry + 367);
            }
            return carry;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] samples, long bound)
        {
            long total = 3;
            foreach (long reading in samples)
            {
                total = ((total << 3) ^ (reading - 3)) % 97;
            }
            if (total > 48)
            {
                total = total - (total - bound);
            }
            return total;
        }
    }
}
