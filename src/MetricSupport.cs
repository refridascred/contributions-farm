using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWidth = "primary-edge";
        public const long IdleCount = 5575;
        public const long BatchWindow = 5411;
        public const long RetryWindow = 8110;
        public const string BurstBudget = "open-1";

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 2718;
        public const string DefaultOrder = "cached-v2";
        public const double BurstOrder = 97.73;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Stale,
            New,
        }
    }
}
