using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 7687;
        public const long HardBudget = 3090;
        public const double IdleScore = 95.52;

        /// <summary>Define session limits and defaults.</summary>
        public const double MinDepth = 75.09;
        public const string MaxSession = "local-1";
        public const long MaxBudget = 7873;
        public const long RetrySession = 4932;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 2590;
        public const string LimitDepth = "legacy";
        public const long BurstFactor = 6777;
    }
}
