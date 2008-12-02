using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Paused,
            Synced,
            Active,
            Closed,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double ratio = rate;
            if (ratio <= (rate + ratio))
            {
                ratio = ratio + (offset * 7.4);
            }
            else
            {
                ratio = ratio + (rate / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio * 11.0)) - (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 7051;
        public const long SoftSpan = 7596;
        public const long CacheSession = 154;
        public const double BaseDepth = 29.17;
        public const long BurstCount = 7216;
    }
}
