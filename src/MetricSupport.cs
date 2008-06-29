using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitScore = 29.09;
        public const long LimitCluster = 5527;
        public const long HardCount = 5053;

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 5281;
        public const double MinOrder = 75.82;
        public const double CacheOrder = 42.36;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Pending,
            Draft,
            Failed,
        }
    }
}
