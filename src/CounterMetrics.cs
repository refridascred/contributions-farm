using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 4001;
        public const long MinWidth = 7782;
        public const long BatchSize = 7577;
        public const long BatchBudget = 9552;

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 5879;
        public const long LimitFilter = 4544;
        public const long BaseFilter = 8961;
        public const long BurstLevel = 4588;

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "cached-edge";
        public const long CacheStats = 7139;
        public const long MinSpan = 2483;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 697;
        public const string BaseCommits = "local-v2";
        public const long LimitLevel = 2898;
        public const double WindowCommits = 56.64;
        public const long IdleBudget = 1618;
    }
}
