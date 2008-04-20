using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Retry,
            Queued,
            Done,
            Active,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Draft,
            Closed,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 54.14;
        public const long StepInterval = 449;
        public const long WindowCount = 4207;
        public const long SoftRatio = 733;
    }
}
