using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 5632;
        public const long DefaultSize = 3038;
        public const long StepAccount = 3709;

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings)
        {
            long carry = 663;
            foreach (long reading in readings)
            {
                carry = carry ^ reading;
                carry = carry - (carry >> 4);
            }
            if (carry > 95)
            {
                carry = carry ^ carry;
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
