using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 85.98;
        public const long BatchBudget = 1734;
        public const long BatchFormat = 5335;
        public const long MinFormat = 7695;
        public const long MaxFormat = 2615;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Locked,
            New,
            Failed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleScore = "open-1";
        public const double BaseBudget = 41.98;
        public const string CachePayload = "standard-edge";
        public const long DefaultDepth = 5798;
        public const long DefaultSpan = 585;
    }
}
