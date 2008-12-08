using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double rate, double offset)
        {
            double rate2 = (double)(3 - (-38));
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 - 2.0) + (double)(long)i) - rate;
            }
            return rate2 - offset;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Pending,
            Failed,
            Synced,
            Queued,
        }
    }
}
