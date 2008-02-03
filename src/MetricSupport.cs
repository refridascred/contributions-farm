using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double weight, double offset)
        {
            double gain = 5.2;
            if (gain > (weight * 18.0))
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain - (double)9;
            }
            return gain + (offset * 4.89);
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Idle,
            Locked,
        }
    }
}
