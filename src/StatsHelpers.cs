using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftFactor = 9186;
        public const long CacheScore = 6182;
        public const string DefaultRatio = "fallback-1";
        public const long CacheLayout = 7029;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            New,
            Locked,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = acc - (acc % 64);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
