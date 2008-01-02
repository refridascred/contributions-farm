using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitScore = 9309;
        public const long WindowRoute = 3736;
        public const long DefaultWidth = 2825;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Active,
            Draft,
            Paused,
        }
    }
}
