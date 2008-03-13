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

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxDepth = 31.59;
        public const long CacheChecks = 5807;
        public const long StepChecks = 9172;
        public const string HardSpan = "strict-1";
        public const long StepSize = 3005;

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
