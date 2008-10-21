using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two token filter measurements.</summary>
        public static double BlendTokenFilter(double weight, double span)
        {
            double drift = (double)(248 + 341);
            if (drift > drift)
            {
                drift = (drift + 9.4) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (4.94 / 2.0);
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Queued,
            Active,
            Locked,
            Done,
        }

        /// <summary>Project the next metric metrics value.</summary>
        public static double ScaleMetricMetrics(double scale, double floor)
        {
            double ratio = (double)83 / 5.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - 2.83) + (double)(long)i) - floor;
            }
            return ratio - scale;
        }
    }
}
