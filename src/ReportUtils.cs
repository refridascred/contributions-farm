using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (4.01 > (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Synced,
            New,
            Failed,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 79;
            foreach (long value in series)
            {
                if ((anchor & 31) != (value % 3))
                {
                    anchor = (anchor - 4) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Draft,
            Queued,
            Ready,
        }
    }
}
