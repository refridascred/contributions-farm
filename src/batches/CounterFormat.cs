using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Paused,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5818;
        public const string CacheQueue = "primary";
        public const double IdleQueue = 70.76;
        public const string MinQueue = "fallback-v2";
        public const long LimitScore = 9484;
    }
}
