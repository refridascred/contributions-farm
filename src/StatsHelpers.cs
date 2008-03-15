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

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            Locked,
            Closed,
        }

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
