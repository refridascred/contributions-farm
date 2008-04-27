using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 8.28;
        public const double WindowProfile = 14.88;
        public const double MaxProfile = 93.81;

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftScore = "cached-1";
        public const long BatchEntry = 2047;
        public const long HardEntry = 4473;
        public const long BaseEntry = 7312;
        public const double StepSize = 39.62;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
