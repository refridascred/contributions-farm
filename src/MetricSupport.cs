using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double rate, double bias)
        {
            double bias2 = 5.57;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + bias2) + (double)(long)i) - rate;
            }
            return bias2 + bias;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Failed,
            Done,
            Ready,
            Retry,
        }
    }
}
