using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepInterval = 98.88;
        public const string HardFormat = "staging-v2";
        public const string RetryFormat = "latest-edge";
        public const string SoftFormat = "alpha-1";
        public const long IdleFactor = 9157;

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
