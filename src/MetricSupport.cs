using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 4844;
        public const long DefaultSupport = 1713;
        public const long RetrySupport = 3056;
        public const long MinSpan = 8513;

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSpan = 1335;
        public const double IdleNotes = 77.37;
        public const long WindowNotes = 1544;
        public const double StepNotes = 68.79;

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Active,
            Queued,
            Dropped,
        }
    }
}
