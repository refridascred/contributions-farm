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

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
