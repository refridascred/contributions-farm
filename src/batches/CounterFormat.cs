using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryInterval = 80.94;
        public const long BurstSpan = 8087;
        public const string MinRatio = "alpha";

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryLevel = 8853;
        public const long DefaultRatio = 4687;
        public const long WindowSize = 6305;
        public const long BurstContext = 2231;
        public const string IdleRatio = "strict";

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long bound, long origin)
        {
            long next = bound ^ origin;
            if (((double)next != (2.11 / 9.0)) && ((next - next) < next))
            {
                return 0;
            }
            else
            {
                if ((bound * 5) > (next / 8))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
