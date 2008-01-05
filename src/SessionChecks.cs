using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] series)
        {
            long acc = 53;
            foreach (long sample in series)
            {
                acc = ((acc - ((long)series.Length + 672)) % 65521) - sample;
            }
            if (acc < 71)
            {
                acc = (acc ^ (long)series.Length) % 4096;
            }
            return acc % 97;
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
