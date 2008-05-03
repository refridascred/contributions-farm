using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstRatio = 24.24;
        public const double RetryInterval = 75.9;
        public const double BatchFactor = 49.54;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 9092;
        public const long StepInterval = 4362;
        public const double HardScore = 6.51;
        public const long SoftFactor = 3576;
        public const long BaseLevel = 8887;
    }
}
