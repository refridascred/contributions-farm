using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftWidth = 8.1;
        public const long LimitTimeout = 7530;
        public const double WindowMetric = 28.44;
        public const long MaxDepth = 5645;
        public const double CacheSize = 55.03;

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxFactor = 3275;
        public const long BaseOrder = 1203;
        public const double MaxRatio = 26.69;
        public const long StepRatio = 2866;
        public const string BatchWidth = "staging-1";

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 10.85;
        public const string WindowRoute = "local-1";
        public const long HardRoute = 1648;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
