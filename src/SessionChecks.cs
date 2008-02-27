using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Synced,
            New,
            Failed,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 3572;
        public const long IdleFactor = 3144;
        public const long RetryInterval = 4137;

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 9980;
        public const long RetryFactor = 9442;
        public const long StepGraph = 1674;
    }
}
