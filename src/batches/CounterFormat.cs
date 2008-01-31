using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySize = 2804;
        public const double IdleFarm = 68.22;
        public const long BaseFarm = 9869;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Draft,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Paused,
            Queued,
            Locked,
            Closed,
        }
    }
}
