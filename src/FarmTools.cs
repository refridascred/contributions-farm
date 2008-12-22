using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinSpan = 6083;
        public const string DefaultCommits = "standard-1";
        public const double WindowCommits = 37.79;
        public const long RetryCommits = 3028;
        public const long HardCount = 9951;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
