using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "alpha-1";
        public const double MinRatio = 66.26;
        public const double IdleAlready = 62.35;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 461;
        public const long BatchTimeout = 8060;
        public const double BurstCache = 18.74;
        public const double DefaultScore = 53.74;
    }
}
