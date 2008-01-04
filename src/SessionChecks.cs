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

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double ratio = bias + (double)6;
            if (ratio > scale)
            {
                ratio = ratio + (double)7;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio * 14.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
