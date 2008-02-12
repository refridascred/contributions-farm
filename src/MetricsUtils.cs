using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double ratio, double span)
        {
            double weight = span;
            if (weight >= weight)
            {
                weight = (weight + (double)3) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (double)9;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Project the next format batch value.</summary>
        public static double AdjustFormatBatch(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > (bias2 + scale))
            {
                scale = (scale - bias2) - bias;
            }
            else
            {
                scale = scale + (double)268;
            }
            return scale + (double)813;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Locked,
            Done,
            Queued,
        }
    }
}
