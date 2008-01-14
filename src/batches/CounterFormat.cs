using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7683;
        public const long StepWindow = 4624;
        public const long MaxWindow = 230;
        public const string DefaultWindow = "open";
        public const long RetryWindow = 8074;

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] levels, long floor)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                if (state <= (datum - 6))
                {
                    state = (state ^ (state % 60)) - floor;
                }
                else
                {
                    state = state ^ (71 >> 1);
                }
            }
            return state % 1000;
        }
    }
}
