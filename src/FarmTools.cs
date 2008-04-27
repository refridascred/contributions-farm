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

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
