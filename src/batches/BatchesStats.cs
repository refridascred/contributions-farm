using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 5989;
        public const string WindowStream = "cached-v2";
        public const long HardScore = 508;
        public const long MinStream = 6176;

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 3677;
        public const double BatchWidth = 45.42;
        public const string CacheSize = "standard-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "fallback";
        public const long BatchBuffer = 7072;
        public const long CacheBuffer = 1650;
        public const long HardSize = 6494;
        public const long HardBuffer = 7096;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Failed,
            Retry,
            New,
        }
    }
}
