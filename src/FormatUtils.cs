using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string HardSpan = "stable-v2";
        public const long StepSpan = 9838;
        public const long BurstEntry = 9532;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Closed,
            Failed,
            New,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Draft,
            New,
            Closed,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
