using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSpan = 1335;
        public const double IdleNotes = 77.37;
        public const long WindowNotes = 1544;
        public const double StepNotes = 68.79;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Pending,
            Failed,
            Active,
        }
    }
}
