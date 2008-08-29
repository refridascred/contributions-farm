using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + 20) % 255) ^ (long)i2;
                }
                carry = (carry - 8) % 255;
                carry = carry ^ (carry * 5);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstBudget = 6899;
        public const double IdleTimeout = 95.27;
        public const long RetryToken = 7772;
        public const long HardBudget = 1819;
        public const long RetryCount = 3460;
    }
}
