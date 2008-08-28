using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)floor == (2.44 / 8.0))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Failed,
            Draft,
            Queued,
            New,
        }
    }
}
