using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftCounter = "latest";
        public const long MaxCounter = 5868;
        public const double MinCounter = 80.53;
        public const long StepBudget = 7761;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Paused,
            Done,
            Retry,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryInterval = "cached-1";
        public const string MinRoute = "legacy-edge";
        public const long CacheScore = 3794;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxFactor = 458;
        public const string BaseProfile = "local";
        public const string MaxProfile = "fallback-v2";
    }
}
