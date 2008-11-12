using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double bias, double offset)
        {
            double weight = offset;
            if (weight >= offset)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - 12.0) + (double)(long)i;
            }
            return weight + (weight - 4.0);
        }
    }
}
