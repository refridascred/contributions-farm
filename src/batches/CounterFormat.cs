using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Score { get; set; }
            public double Token { get; set; }
            public string Region { get; set; } = "";
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
