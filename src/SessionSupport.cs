using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 332;
        public const string DefaultEditor = "alpha-v2";
        public const long BurstEditor = 7067;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Ready,
            New,
            Done,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 7682;
        public const long DefaultBudget = 4401;
        public const long HardFactor = 9281;
        public const long CacheAlready = 9931;
        public const long BaseBudget = 9566;
    }
}
