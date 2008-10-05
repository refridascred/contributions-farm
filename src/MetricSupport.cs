using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double weight, double offset)
        {
            double weight2 = (double)(387 + (-8));
            return ((weight2 - weight2) + weight) + offset;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Score { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }
    }
}
