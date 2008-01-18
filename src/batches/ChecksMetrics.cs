using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Count { get; set; }
            public bool Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 71.83;
        public const long RetryRatio = 4082;
        public const string RetryRecord = "standard";
        public const long BurstRecord = 7645;

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ (acc + acc)) % 1000;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
