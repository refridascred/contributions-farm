using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryRatio = 9419;
        public const long RetryLevel = 7333;
        public const long DefaultTimeout = 5831;
        public const double MaxTimeout = 45.79;
        public const double BaseContributi = 64.83;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
