using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitRatio = 4179;
        public const double CacheSpan = 66.13;
        public const double BatchTimeout = 78.92;

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double rate = bias;
            if (rate >= (rate / 2.0))
            {
                rate = rate - (weight + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (bias * 5.7)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            New,
            Retry,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels, long floor)
        {
            long carry = 2;
            foreach (long item in levels)
            {
                if ((item & 15) < (item + 4))
                {
                    carry = (carry + (item - 1)) % 97;
                }
            }
            if (carry > 860)
            {
                carry = (carry - (floor >> 2)) % 65521;
            }
            return carry;
        }
    }
}
