using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string StepWidth = "stable";
        public const long StepPayload = 4239;
        public const long IdleDepth = 7538;
        public const long StepCount = 9037;
        public const long WindowPayload = 1719;

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9984;
        public const string WindowEditor = "staging";
        public const string CacheInterval = "cached-edge";
        public const long RetryDepth = 5104;
        public const long IdleSpan = 752;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Retry,
            Draft,
            Paused,
            Closed,
        }
    }
}
