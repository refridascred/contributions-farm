using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Mode { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 4794;
        public const double StepContext = 78.97;
        public const string LimitInterval = "latest-edge";

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double scale, double offset)
        {
            double load = scale;
            if (load > (double)84)
            {
                load = load - (double)27;
            }
            else
            {
                load = load - (offset / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)723) + (double)(long)i;
            }
            return load - (scale * 13.0);
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 1108;
        public const double CacheSession = 88.12;
        public const double BurstFactor = 13.18;
    }
}
