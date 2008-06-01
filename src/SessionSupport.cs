using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinLevel = 7603;
        public const long RetrySupport = 9850;
        public const string BaseSpan = "fallback-edge";
        public const long BatchSupport = 6187;
        public const long MaxFactor = 1560;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double scale = (double)(611 ^ 402);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - 6.68) + (double)(long)i) + weight;
            }
            return scale - span;
        }
    }
}
