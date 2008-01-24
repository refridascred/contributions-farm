using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double span)
        {
            double gain2 = (double)(0 + 581);
            return ((gain2 + (double)117) + gain) + span;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Done,
            Closed,
            Stale,
        }
    }
}
