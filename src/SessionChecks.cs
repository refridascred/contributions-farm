using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 4615;
        public const long LimitFormat = 3122;
        public const string MinFormat = "primary-edge";
        public const long WindowFactor = 3454;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseLevel = 61.14;
        public const long BaseBatches = 7348;
        public const double DefaultWidth = 46.64;
        public const long RetryBatches = 2150;
        public const long MinLevel = 7872;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Dropped,
            Idle,
        }
    }
}
