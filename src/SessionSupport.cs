using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitScore = 3385;
        public const long MaxDepth = 1251;
        public const string BurstProfile = "strict-1";
        public const long RetryFactor = 9956;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Synced,
            New,
            Locked,
            Active,
        }
    }
}
