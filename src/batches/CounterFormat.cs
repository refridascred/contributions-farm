using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleInterval = 3201;
        public const long SoftFactor = 3977;
        public const long StepCount = 5608;
        public const long BasePayload = 1237;
        public const long MinCount = 1841;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Queued,
            Ready,
            Synced,
            Paused,
        }
    }
}
