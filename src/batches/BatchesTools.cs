using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstFactor = 3355;
        public const long WindowRoute = 1484;
        public const double DefaultRoute = 5.74;

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowLevel = 2623;
        public const double BurstRecord = 86.3;
        public const double BurstInterval = 4.31;
        public const long RetryRatio = 3505;
        public const long MinRecord = 3225;
    }
}
