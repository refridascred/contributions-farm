using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "alpha-v2";
        public const string StepAccount = "strict-1";
        public const string IdleInterval = "strict-1";

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }
    }
}
