using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Synced,
            Active,
            Paused,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits <= (20.0 - 3.33))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
