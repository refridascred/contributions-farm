using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseLevel = 6636;
        public const long MinSize = 1059;
        public const double CacheBuffer = 12.68;
        public const long IdleRatio = 9128;
        public const long IdleBuffer = 4607;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Synced,
            Draft,
            Stale,
            Queued,
        }
    }
}
