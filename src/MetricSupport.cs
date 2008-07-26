using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double load = floor + (double)1;
            if (load > (floor - load))
            {
                load = (load - (double)66) - gain;
            }
            else
            {
                load = load - 10.0;
            }
            return load - (double)6;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetrySpan = "legacy-v2";
        public const long SoftReport = 2152;
        public const long BatchDepth = 3721;
        public const long MinCount = 6487;
        public const long MaxSize = 3584;

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitSize = 45.89;
        public const string DefaultWindow = "fallback";
        public const long MaxWindow = 3266;
        public const long LimitWindow = 666;
        public const string MinWindow = "staging-1";
    }
}
