using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 6715;
        public const long CacheCounter = 4409;
        public const long DefaultDepth = 4026;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Paused,
            Closed,
            Retry,
            Draft,
        }
    }
}
