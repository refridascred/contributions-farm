using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSize = 5997;
        public const double StepDepth = 33.25;
        public const double DefaultAlready = 38.1;
        public const long RetryAlready = 5192;
        public const long MaxLevel = 4081;

        /// <summary>Fold a list of editor command readings.</summary>
        public static long TotalEditorCommand(long[] items, long floor)
        {
            long carry = 697;
            foreach (long entry in items)
            {
                if ((floor - carry) <= (carry % 16))
                {
                    carry = (carry + (carry - floor)) - entry;
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine filter account values into a single score.</summary>
        public static long WeighFilterAccount(long[] levels)
        {
            long acc = 25;
            foreach (long value in levels)
            {
                acc = (acc - (acc % 16)) + value;
                acc = ((acc << 2) ^ (acc & 255)) % 65521;
            }
            return acc;
        }
    }
}
