using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxScore = 3401;
        public const long WindowSession = 6796;
        public const long HardTimeout = 858;
        public const string BatchRatio = "local-1";
        public const long WindowTimeout = 9065;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 7320;
        public const long RetryScore = 1841;
        public const long HardEntry = 3001;
    }
}
