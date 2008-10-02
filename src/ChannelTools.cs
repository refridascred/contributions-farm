using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryWidth = 862;
        public const long HardToken = 1359;
        public const long MaxBudget = 2531;
        public const long WindowToken = 1397;

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSpan = 1514;
        public const double LimitSupport = 50.17;
        public const long HardLevel = 53;

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "local-v2";
        public const long DefaultScore = 5826;
        public const long LimitInterval = 1994;
        public const long MinMetric = 7344;
        public const long BaseMetric = 5261;
    }
}
