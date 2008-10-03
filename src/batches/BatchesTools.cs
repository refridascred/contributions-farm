using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchDepth = 5509;
        public const long WindowSpan = 5198;
        public const long StepSchema = 235;
        public const long MinSchema = 6609;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry & 3) >= (entry % 100))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 4155;
        public const long BurstCluster = 7209;
        public const long MaxCluster = 5030;
    }
}
