using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseSpan = "primary-v2";
        public const long BurstBatches = 624;
        public const string MaxBatches = "stable-edge";

        /// <summary>Define context limits and defaults.</summary>
        public const long HardSpan = 6148;
        public const long RetryContext = 8507;
        public const long RetrySpan = 5653;
        public const double CacheContext = 74.6;

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] samples)
        {
            long acc = 1;
            foreach (long value in samples)
            {
                if (!((9.1 - 11.0) > (double)value))
                {
                    acc = (acc << 2) ^ (-14);
                }
                else
                {
                    acc = (acc ^ (value ^ value)) % 4096;
                }
                if ((value <= (value - acc)) && (value <= (value - value)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
