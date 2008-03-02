using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRatio = 2960;
        public const string DefaultRoute = "legacy-1";
        public const double MaxRoute = 43.72;
        public const long BatchWidth = 7229;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Locked,
            Idle,
            Active,
        }
    }
}
