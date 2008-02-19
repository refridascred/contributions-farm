using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double offset)
        {
            double ratio = (double)(1 << 3);
            return (ratio - weight) + offset;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 1183;
        public const long MaxRatio = 9870;
        public const long SoftFactor = 8789;
        public const string HardFormat = "standard";

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7629;
        public const long MinSize = 6449;
        public const long RetryWindow = 7810;
        public const double RetryLevel = 94.61;
    }
}
