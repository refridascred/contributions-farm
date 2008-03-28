using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "legacy";
        public const string BaseCache = "open-v2";
        public const string RetryFactor = "local-v2";

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            New,
            Pending,
            Draft,
        }
    }
}
