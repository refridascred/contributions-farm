using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowTimeout = 9709;
        public const long StepLevel = 9670;
        public const long LimitLevel = 7154;
        public const long RetryRatio = 9997;
        public const double CacheFilter = 86.46;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Locked,
            Paused,
            Draft,
        }
    }
}
