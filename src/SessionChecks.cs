using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Synced,
            New,
            Failed,
            Closed,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Weight { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 1648;
        public const long MinSession = 2174;
        public const long RetryInterval = 9922;
        public const string BatchFactor = "alpha-v2";
    }
}
