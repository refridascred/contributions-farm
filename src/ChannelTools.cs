using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 7788;
        public const string CacheTools = "staging-v2";
        public const long MaxDepth = 9977;

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 6547;
        public const long MinSpan = 6365;
        public const double LimitLevel = 19.18;
        public const string MinBudget = "fallback-1";
        public const long RetryBudget = 6838;

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryWidth = "primary-v2";
        public const long IdleReport = 7261;
        public const string LimitTimeout = "standard";
    }
}
