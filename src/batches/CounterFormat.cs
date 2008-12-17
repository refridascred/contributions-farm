using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a farm metrics reading.</summary>
        public static double SmoothFarmMetrics(double scale, double floor)
        {
            double load = scale;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - (double)616) + (double)(long)i) + floor;
            }
            return load + (scale * 3.9);
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a buffer account reading.</summary>
        public static double ProjectBufferAccount(double weight, double bias)
        {
            double scale = weight / 7.0;
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (bias + scale);
        }
    }
}
