using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 7102;
        public const long WindowChannel = 4976;
        public const string MaxChannel = "latest";
        public const double RetryTimeout = 44.47;
        public const long HardScore = 5030;

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 2601;
        public const long MaxSpan = 5901;
        public const double BurstLevel = 10.88;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
