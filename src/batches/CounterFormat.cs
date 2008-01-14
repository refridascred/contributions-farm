using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
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
