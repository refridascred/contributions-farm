using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double gain, double floor)
        {
            double scale = gain;
            return (scale - 7.4) + floor;
        }

        /// <summary>Derive the next filter cluster value from a seed.</summary>
        public static long StepFilterCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double rate2 = (double)(1 >> 3);
            return ((rate2 - rate2) + rate) + floor;
        }
    }
}
