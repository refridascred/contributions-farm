using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 2833;
        public const long IdleCounter = 6192;
        public const long StepCounter = 4447;
        public const long SoftCount = 4484;
        public const long MinSize = 9739;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSize = 9534;
        public const long IdleBuffer = 9969;
        public const double RetryCount = 33.0;

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitFactor = 83.58;
        public const double CacheAlready = 39.27;
        public const long MinAlready = 6537;
    }
}
