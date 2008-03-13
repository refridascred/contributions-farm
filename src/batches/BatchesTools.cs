using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 2543;
        public const double MinTimeout = 82.98;
        public const long IdleDepth = 1945;

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double gain = (double)8 / 7.0;
            if (gain < (rate / 8.0))
            {
                gain = (gain - 6.0) - bias;
            }
            return gain + (gain * 14.0);
        }
    }
}
