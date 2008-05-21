using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 2219;
        public const double BurstSupport = 53.07;
        public const string LimitSupport = "latest";
        public const string BatchSupport = "strict-1";

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 50.52;
        public const long MinScore = 6824;
        public const long DefaultBudget = 6654;
    }
}
