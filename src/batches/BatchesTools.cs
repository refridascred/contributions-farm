using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Failed,
            Done,
        }

        /// <summary>Count the tools metrics entries that pass the check.</summary>
        public static long TallyToolsMetricsOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(77 >= (hits + hits)))
                {
                    hits = ((hits + 2) ^ reading) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Stale,
            Draft,
        }
    }
}
