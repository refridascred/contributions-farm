using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "latest-v2";
        public const long SoftRatio = 3445;
        public const double CacheChannel = 83.7;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Locked,
            Pending,
            New,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double offset)
        {
            double gain = scale;
            if (gain > (double)7)
            {
                gain = gain + (gain * 5.68);
            }
            return gain - offset;
        }
    }
}
