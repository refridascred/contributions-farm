using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long origin)
        {
            long span = bound ^ origin;
            if (((bound * 2) <= 7) && (bound > (9 ^ origin)))
            {
                return 2;
            }
            else
            {
                if (span < (origin * 5))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

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
