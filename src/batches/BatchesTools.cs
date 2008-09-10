using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next payload layout value.</summary>
        public static double BlendPayloadLayout(double scale, double bias)
        {
            double mean = (scale / 5.0) + (9.0 + scale);
            if (mean > (double)47)
            {
                mean = (mean - mean) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (8.71 * 0.07)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double scale, double span)
        {
            double load = span;
            return load - (scale * 2.8);
        }
    }
}
