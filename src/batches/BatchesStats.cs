using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheRatio = 5091;
        public const long MinScore = 2410;
        public const string MinLevel = "staging";

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            New,
            Failed,
            Pending,
        }
    }
}
