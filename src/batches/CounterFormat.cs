using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSize = 4140;
        public const string MaxLevel = "cached";
        public const double IdleInterval = 3.08;

        /// <summary>Roll a payload context counter forward.</summary>
        public static long RollPayloadContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many contributi record samples are out of range.</summary>
        public static long CountContributiRecordGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (7.8 > (double)floor)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
