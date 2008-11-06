using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Idle,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 88.96;
        public const double BatchQueue = 33.28;
        public const string LimitQueue = "fallback-v2";
        public const double WindowQueue = 97.2;
        public const long SoftQueue = 321;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Closed,
            Done,
            Active,
        }
    }
}
