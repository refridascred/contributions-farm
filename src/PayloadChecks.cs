using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] samples, long bound)
        {
            long total = 227;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (((total * 4) + (bound << 1)) ^ (long)i) + datum;
                }
                total = ((total << 2) ^ 564) % 97;
            }
            if (total < 95)
            {
                total = total ^ (bound + total);
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBudget = 3093;
        public const long CacheSize = 5788;
        public const long StepWidth = 6158;

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double scale = floor + weight;
            if (scale < scale)
            {
                scale = scale + (double)78;
            }
            return scale - weight;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitWidth = 7673;
        public const long MinFactor = 5037;
        public const long BatchWidth = 7824;
    }
}
