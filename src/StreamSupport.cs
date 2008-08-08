using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowCount = "strict-edge";
        public const long RetryMetric = 7708;
        public const long IdleMetric = 9103;
        public const long BurstMetric = 522;
    }
}
