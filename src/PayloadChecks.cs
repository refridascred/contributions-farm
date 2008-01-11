using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double weight, double bias)
        {
            double load = (bias * 7.0) / 6.0;
            if (load < (double)8)
            {
                load = load - load;
            }
            else
            {
                load = load + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(-3)) + (double)(long)i;
            }
            return load - (double)92;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
