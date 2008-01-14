using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double HardCount = 87.28;
        public const long IdleAccount = 7085;
        public const double MaxAccount = 56.3;
        public const long SoftScore = 3613;
        public const long BaseAccount = 8223;

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
