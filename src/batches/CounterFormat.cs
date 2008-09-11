using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Failed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowInterval = "stable-edge";
        public const string LimitTools = "fallback-v2";
        public const long RetryTools = 5779;
    }
}
