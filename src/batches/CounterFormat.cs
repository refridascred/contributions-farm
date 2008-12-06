using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 4336;
        public const long HardContributi = 4907;
        public const long BatchWidth = 2516;
        public const long WindowSpan = 6377;
        public const string DefaultContributi = "standard-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 7268;
        public const string MaxMetric = "standard-v2";
        public const string MinMetric = "local";
        public const long RetrySize = 4087;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Failed,
            Synced,
            Dropped,
        }
    }
}
