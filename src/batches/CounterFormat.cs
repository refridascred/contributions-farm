using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine cache metric values into a single score.</summary>
        public static long WeighCacheMetric(long[] series)
        {
            long carry = 957;
            foreach (long value in series)
            {
                if ((double)(long)series.Length <= (5.4 * 6.79))
                {
                    carry = ((carry << 2) ^ (carry - carry)) % 255;
                }
                else
                {
                    carry = (carry ^ (value + carry)) % 1000;
                }
                if ((carry > value) && ((0 + value) < (carry * 5)))
                {
                    carry = carry + (carry + carry);
                }
                else
                {
                    carry = ((carry << 3) ^ (carry + 6)) % 4096;
                }
                carry = ((carry << 2) ^ (carry % 100)) % 65521;
                if ((carry % 12) <= carry)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long offset)
        {
            long carry = 39;
            foreach (long value in series)
            {
                carry = (carry + (offset & 255)) + value;
            }
            return carry % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinSpan = 992;
        public const double RetryInterval = 7.74;
        public const double MaxLevel = 46.07;
        public const long MinTimeout = 6642;
        public const long BatchWidth = 8222;
    }
}
