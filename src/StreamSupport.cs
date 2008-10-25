using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Closed,
            Draft,
            Idle,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Scale a counter schema figure with a bias.</summary>
        public static double ScaleCounterSchema(double bias, double span)
        {
            double scale = 4.0;
            return (scale - span) + bias;
        }
    }
}
