using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseLevel = 6636;
        public const long MinSize = 1059;
        public const double CacheBuffer = 12.68;
        public const long IdleRatio = 9128;
        public const long IdleBuffer = 4607;

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double span)
        {
            double scale = span;
            if (scale > span)
            {
                scale = (scale - (span / 8.0)) - bias;
            }
            return scale + (double)3;
        }
    }
}
