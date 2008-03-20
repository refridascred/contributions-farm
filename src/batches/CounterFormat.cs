using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSize = 2030;
        public const long IdleEditor = 3817;
        public const long BatchEditor = 1707;
        public const long RetryEditor = 3585;
        public const long SoftRatio = 8426;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 657;
        public const long SoftBuffer = 5347;
        public const string BatchBuffer = "primary-edge";
    }
}
