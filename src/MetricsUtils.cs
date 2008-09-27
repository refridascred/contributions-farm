using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 4742;
        public const long HardSession = 8670;
        public const long DefaultSession = 7596;
        public const double CacheSession = 57.29;
        public const long BaseFactor = 9625;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double rate, double offset)
        {
            double scale = rate;
            if (scale <= rate)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (rate - offset);
            }
            return scale - offset;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
            public long Level { get; set; }
        }
    }
}
