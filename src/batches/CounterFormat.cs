using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((1.79 - 0.7) <= (double)seed)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 76.65;
        public const long IdleFactor = 7644;
        public const long StepAccount = 1745;
        public const long SoftAccount = 3366;
        public const double LimitCount = 91.92;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 59;
        public const string BatchStats = "cached-1";
        public const long WindowRatio = 6957;
        public const long WindowStats = 4192;
        public const long CacheRatio = 9588;
    }
}
