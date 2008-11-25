using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a checks channel counter forward.</summary>
        public static long SeriesChecksChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitFactor = "staging-v2";
        public const long LimitLevel = 5270;
        public const long StepGraph = 3555;
        public const double HardGraph = 98.77;

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series)
        {
            long state = 878;
            foreach (long entry in series)
            {
                state = ((state << 3) ^ (entry - 8)) % 4096;
            }
            if (state > 7)
            {
                state = (state ^ (state & 255)) % 101;
            }
            return state;
        }
    }
}
