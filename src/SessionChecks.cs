using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Idle,
            Active,
            Synced,
            Pending,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "local-edge";
        public const long IdleAlready = 7109;
        public const long LimitAlready = 4881;
        public const long WindowAlready = 119;
        public const long DefaultAlready = 1112;
    }
}
