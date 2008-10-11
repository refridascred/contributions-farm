using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 73.8;
        public const long MaxFactor = 7750;
        public const long CacheContributi = 3282;
        public const long SoftLevel = 9443;

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultDepth = "strict-v2";
        public const long BurstCounter = 7088;
        public const string StepLevel = "stable-edge";
        public const string SoftCounter = "stable-edge";

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 9403;
        public const double DefaultSize = 55.25;
        public const long BaseBatch = 853;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
