using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 562;
        public const long SoftRatio = 4958;
        public const long StepWidth = 6937;
        public const long RetryToken = 9166;
        public const double MaxLevel = 71.83;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            New,
            Locked,
            Failed,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowCount = "open";
        public const double BurstSize = 37.96;
        public const double CacheWindow = 65.19;
        public const long WindowSpan = 6697;
        public const long HardWindow = 3564;
    }
}
