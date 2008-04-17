using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryLevel = 723;
        public const long BaseSession = 430;
        public const string BaseLevel = "primary-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 9008;
        public const long BatchSize = 7529;
        public const long CacheQueue = 8416;
    }
}
