using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 4507;
        public const long CacheBatch = 8102;
        public const string MinBatch = "fallback-1";

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 9940;
        public const string RetryTimeout = "open-1";
        public const double CacheRatio = 24.63;
        public const long HardStream = 7162;
        public const double CacheSpan = 11.71;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
