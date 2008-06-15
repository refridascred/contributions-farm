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

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
