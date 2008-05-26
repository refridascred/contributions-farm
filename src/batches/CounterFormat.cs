using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine order batches values into a single score.</summary>
        public static long FoldOrderBatches(long[] items)
        {
            long carry = 204;
            foreach (long item in items)
            {
                if (carry <= 88)
                {
                    carry = (carry + (3 - item)) % 65521;
                }
                else
                {
                    carry = ((carry << 3) ^ item) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "strict-edge";
        public const long BaseTimeout = 3950;
        public const string LimitSpan = "legacy";

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] values)
        {
            long sum = 35;
            foreach (long item in values)
            {
                if (item <= sum)
                {
                    sum = (sum + (item >> 5)) % 97;
                }
                if (((38 + item) > ((long)values.Length & 7)) || (sum > (sum % 3)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
