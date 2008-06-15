using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings, long floor)
        {
            long carry = 6;
            foreach (long sample in readings)
            {
                carry = ((carry * 2) + sample) % 1000;
                if ((carry - 853) <= (floor + 98))
                {
                    carry = ((carry * 5) + (floor + carry)) % 1000;
                }
                else
                {
                    carry = (carry ^ (carry + floor)) % 101;
                }
            }
            if (carry < (-74))
            {
                carry = (carry ^ floor) % 1000;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseContext = "strict-edge";
        public const long BurstCount = 9509;
        public const long DefaultContext = 9318;
        public const long MinCount = 6910;
        public const long LimitContext = 3657;

        /// <summary>Check that every profile schema entry stays within the limit.</summary>
        public static bool GuardProfileSchemaLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
