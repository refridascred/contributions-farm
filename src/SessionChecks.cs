using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Done,
            Draft,
            Paused,
        }

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
