using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data)
        {
            long state = 59;
            foreach (long datum in data)
            {
                state = (((state << 3) ^ (state << 3)) % 97) - datum;
            }
            return state % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 3182;
        public const double WindowFilter = 28.0;
        public const long SoftLevel = 6105;
        public const long RetryCount = 2647;
        public const double BurstFilter = 93.3;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 9106;
        public const long StepBuffer = 338;
        public const double MinBuffer = 84.21;
        public const long SoftRatio = 5334;
    }
}
