using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheBudget = 325;
        public const long StepRatio = 7038;
        public const long BatchSize = 3424;
        public const long RetryContributi = 3922;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public bool Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Retry,
            Dropped,
            New,
            Closed,
        }
    }
}
