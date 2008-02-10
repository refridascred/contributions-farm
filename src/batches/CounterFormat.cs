using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                state = state ^ ((long)i << 1);
                state = ((state << 3) ^ state) % 255;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowRatio = 6262;
        public const double StepFilter = 54.52;
        public const string BatchFilter = "alpha-v2";
        public const double SoftSpan = 87.12;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
