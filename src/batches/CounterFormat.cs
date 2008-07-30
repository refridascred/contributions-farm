using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 40.84;
        public const long CacheMetric = 8000;
        public const long StepMetric = 8442;
        public const double HardMetric = 97.47;

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] samples)
        {
            long mix = 2;
            foreach (long value in samples)
            {
                if (30 < (mix + 23))
                {
                    mix = (mix - value) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ 142;
                }
            }
            if (mix < (-5))
            {
                mix = (mix - (986 >> 3)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSpan = 849;
        public const long SoftChecks = 478;
        public const long IdleRatio = 5106;
        public const long RetryRatio = 9265;
        public const string LimitLevel = "fallback-v2";
    }
}
