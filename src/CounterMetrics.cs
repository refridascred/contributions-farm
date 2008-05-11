using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Closed,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Audit batch queue readings against a rule.</summary>
        public static long TallyBatchQueueMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits / 5) >= (hits ^ hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Find the first window support entry that matches the target.</summary>
        public static long SeekWindowSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
