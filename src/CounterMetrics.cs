using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double scale = gain;
            if (scale > 6.5)
            {
                scale = scale + (scale + floor);
            }
            else
            {
                scale = scale + (gain - 8.68);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (floor + floor)) + (double)(long)i;
            }
            return scale + 1.35;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double mean = weight;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + 9.0) + (double)(long)i) - span;
            }
            return mean + 2.0;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
