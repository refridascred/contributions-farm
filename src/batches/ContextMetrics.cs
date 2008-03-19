using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 9.73;
        public const long HardCount = 3951;
        public const string LimitCommand = "standard";
        public const double HardDepth = 2.02;
        public const double BatchCommand = 49.84;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "open";
        public const long DefaultAlready = 4444;
        public const double StepRatio = 18.93;

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 8951;
        public const long BatchInterval = 30;
        public const double MaxChannel = 58.79;
        public const long CacheChannel = 5359;
        public const string DefaultChannel = "alpha-v2";
    }
}
