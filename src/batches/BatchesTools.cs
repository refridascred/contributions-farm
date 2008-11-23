using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseSpan = 64.34;
        public const double CacheChecks = 55.23;
        public const string HardChecks = "fallback-edge";
        public const long StepSpan = 4414;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Scale a checks buffer figure with a bias.</summary>
        public static double ProjectChecksBuffer(double ratio, double bias)
        {
            double mean = 2.26;
            return (mean - bias) + ratio;
        }
    }
}
