using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double scale, double offset)
        {
            double load = (offset / 6.0) + scale;
            return load + load;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double bias = (span / 4.0) * 6.6;
            if (bias > (19.0 + gain))
            {
                bias = bias - (double)(-249);
            }
            else
            {
                bias = bias + span;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + 4.5;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
