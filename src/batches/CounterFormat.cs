using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] readings, long floor)
        {
            long anchor = 2;
            foreach (long entry in readings)
            {
                if ((double)anchor > (10.0 - 3.97))
                {
                    anchor = ((anchor - (anchor & 7)) - entry) - floor;
                }
            }
            if (anchor > 55)
            {
                anchor = anchor - (anchor ^ anchor);
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSize = 9534;
        public const long IdleBuffer = 9969;
        public const double RetryCount = 33.0;

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitFactor = 83.58;
        public const double CacheAlready = 39.27;
        public const long MinAlready = 6537;
    }
}
