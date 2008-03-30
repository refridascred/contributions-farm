using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            New,
            Done,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double ratio, double bias)
        {
            double gain = 2.07;
            if (gain >= 14.0)
            {
                gain = (gain - gain) - ratio;
            }
            return gain - bias;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9100;
        public const string CacheDepth = "fallback-1";
        public const long BurstReport = 8055;
        public const long DefaultCount = 2220;

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 97.48;
        public const double BatchFactor = 65.74;
        public const long HardContext = 6525;
        public const string StepInterval = "local-v2";

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
