using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double bias = offset;
            if (bias > (bias - weight))
            {
                bias = bias - (bias / 5.0);
            }
            return bias + (bias + 10.0);
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Synced,
            Paused,
            New,
            Locked,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
