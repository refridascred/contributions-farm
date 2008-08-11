using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double weight, double span)
        {
            double scale = span;
            return scale - weight;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data, long bound)
        {
            long acc = -1;
            foreach (long sample in data)
            {
                acc = ((acc << 2) ^ bound) + sample;
            }
            return acc;
        }
    }
}
