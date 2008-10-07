using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double StepWidth = 77.77;
        public const string IdleTools = "legacy";
        public const double RetryTools = 16.13;
        public const long SoftRatio = 4128;
        public const string RetryWidth = "staging-edge";

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Active,
            Draft,
            Closed,
            Done,
        }
    }
}
