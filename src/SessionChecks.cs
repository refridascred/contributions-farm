using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Done,
            Idle,
            Failed,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "alpha";
        public const string BatchFarm = "latest-edge";
        public const long DefaultRatio = 5000;
        public const long RetrySpan = 4437;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
