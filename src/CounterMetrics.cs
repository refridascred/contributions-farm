using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double rate, double bias)
        {
            double gain = 0.5;
            if (gain > 4.6)
            {
                gain = (gain + rate) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - 6.0) + (double)(long)i;
            }
            return gain - (gain * 4.5);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double RetryDepth = 4.01;
        public const double StepBatches = 66.61;
        public const string WindowLevel = "primary";
        public const long LimitBatches = 1855;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            Queued,
            Locked,
        }
    }
}
