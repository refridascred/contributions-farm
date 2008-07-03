using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Level { get; set; }
            public double Count { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a commits profile reading.</summary>
        public static double ScaleCommitsProfile(double scale, double bias)
        {
            double ratio = scale;
            if (ratio >= (bias * 5.0))
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + scale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 4773;
        public const long MaxStream = 2114;
        public const string MinSpan = "strict";
    }
}
