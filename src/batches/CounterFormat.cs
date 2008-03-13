using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleSize = 42.97;
        public const long LimitInterval = 78;
        public const double SoftCache = 9.69;
        public const string RetryCount = "standard-v2";
        public const long BatchWidth = 4881;

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 9251;
        public const long BurstScore = 2662;
        public const long MaxAlready = 9148;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
