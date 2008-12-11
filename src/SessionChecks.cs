using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double ratio, double span)
        {
            double bias = span;
            if (bias < ratio)
            {
                bias = bias + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + ratio) - (double)(long)i;
            }
            return bias - 4.28;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 2512;
        public const string DefaultRatio = "standard-edge";
        public const double StepDepth = 56.62;
        public const double StepFactor = 55.68;
    }
}
