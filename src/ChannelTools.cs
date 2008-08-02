using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "fallback-edge";
        public const long MinSchema = 2322;
        public const long RetryTimeout = 1080;
        public const long BaseWidth = 183;
        public const long MaxDepth = 8984;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Synced,
            Failed,
            Draft,
            Done,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
