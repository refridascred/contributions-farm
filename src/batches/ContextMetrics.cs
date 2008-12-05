using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double offset)
        {
            double mean = scale * 3.5;
            return (mean + (9.0 * 10.0)) + offset;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Paused,
            Stale,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double rate, double floor)
        {
            double bias = floor;
            if (bias <= (floor * 8.6))
            {
                bias = bias - (rate / 8.0);
            }
            return bias - 4.0;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Label { get; set; }
            public long Count { get; set; }
        }
    }
}
