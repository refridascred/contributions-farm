using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Draft,
            Closed,
            Queued,
            Active,
            New,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count stats contributi pairs that satisfy a relation.</summary>
        public static long OverlapStatsContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
