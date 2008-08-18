using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitInterval = 94.03;
        public const long BatchCache = 9993;
        public const double StepFactor = 88.87;
        public const string StepCache = "cached-edge";

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Closed,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Retry,
            Synced,
        }
    }
}
