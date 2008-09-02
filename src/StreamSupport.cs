using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 4822;
        public const long BatchBudget = 9764;
        public const double CacheEntry = 3.11;
        public const string IdleDepth = "open-v2";

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double weight, double span)
        {
            double mean = 15.0 - span;
            if (mean <= (double)171)
            {
                mean = (mean - (2.88 * 4.52)) + weight;
            }
            return mean + span;
        }
    }
}
