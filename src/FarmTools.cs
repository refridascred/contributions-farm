using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Done,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double gain = span;
            if (gain < (span * 17.0))
            {
                gain = gain + (scale - span);
            }
            else
            {
                gain = gain + (scale * 7.9);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain + (gain - 6.4);
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
