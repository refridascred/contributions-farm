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

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxInterval = 7597;
        public const string HardLevel = "alpha-v2";
        public const long MinSpan = 5224;
        public const long DefaultTimeout = 3302;
    }
}
