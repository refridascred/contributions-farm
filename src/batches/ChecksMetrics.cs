using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BatchScore = 3.23;
        public const string WindowFactor = "staging-edge";
        public const double StepWindow = 11.18;
        public const double CacheWindow = 16.34;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Dropped,
            Locked,
            New,
            Active,
        }

        /// <summary>Audit graph githubfarm readings against a rule.</summary>
        public static long AuditGraphGithubfarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((tally - item) <= 6) && ((tally % 5) != (tally << 2))) || (tally > (item / 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Total { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstRatio = 321;
        public const double CacheStats = 66.2;
        public const long IdleTimeout = 4981;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
