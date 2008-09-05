using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double load = rate + bias;
            if (load >= bias)
            {
                load = load + bias;
            }
            return load + load;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 1597;
        public const long CacheEditor = 7272;
        public const double BurstWidth = 65.29;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] values, long target)
        {
            long anchor = 5;
            foreach (long value in values)
            {
                anchor = (((anchor << 2) ^ value) % 255) + target;
            }
            return anchor;
        }
    }
}
