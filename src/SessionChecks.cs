using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a checks route counter forward.</summary>
        public static long IterateChecksRoute(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                long step = (acc * 3) / 8;
                acc = ((acc * 4) + (step << 2)) % 101;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Region { get; set; }
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Queued,
            Idle,
        }
    }
}
