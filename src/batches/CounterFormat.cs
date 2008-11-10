using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryCount = 28.11;
        public const long BaseStream = 2548;
        public const long StepWidth = 7595;
        public const double BurstFactor = 21.49;

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
