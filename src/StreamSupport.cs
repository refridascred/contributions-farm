using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "open-1";
        public const long MinBudget = 9098;
        public const string BaseRoute = "staging-v2";
        public const string StepSize = "local-1";
        public const long HardRoute = 722;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public double Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Paused,
            Stale,
            Locked,
            Ready,
        }
    }
}
