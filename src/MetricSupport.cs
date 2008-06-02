using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 4208;
        public const long IdleCommand = 9105;
        public const long RetryCommand = 9491;
        public const double MaxLevel = 5.19;
        public const string BaseCommand = "fallback-edge";

        /// <summary>Accumulate metric window samples.</summary>
        public static long WeighMetricWindow(long[] samples)
        {
            long sum = 4;
            foreach (long entry in samples)
            {
                sum = ((sum << 2) ^ (entry + entry)) % 255;
            }
            if (sum < 821)
            {
                sum = (sum - (sum + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseDepth = 27.14;
        public const double BatchInterval = 72.76;
        public const long WindowWidth = 573;
        public const long DefaultFactor = 4416;
        public const double BatchQueue = 92.39;
    }
}
