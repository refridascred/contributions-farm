using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Scale a stats counter figure with a bias.</summary>
        public static double AdjustStatsCounter(double ratio, double span)
        {
            double mean = ratio;
            if (mean <= (4.0 - span))
            {
                mean = mean + ratio;
            }
            return mean - mean;
        }
    }
}
