using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string WindowFactor = "stable-edge";
        public const string LimitTimeout = "strict-edge";
        public const long WindowToken = 8828;

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "standard";
        public const long MaxCounter = 7554;
        public const long StepCounter = 9249;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }
    }
}
