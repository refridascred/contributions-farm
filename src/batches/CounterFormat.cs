using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 4689;
        public const double MinWidth = 48.17;
        public const string SoftChannel = "legacy";
        public const long IdleBudget = 2561;

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
