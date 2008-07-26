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

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 995;
        public const double BurstCount = 60.63;
        public const double BatchSize = 65.69;
    }
}
