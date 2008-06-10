using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)bound < (9.31 + 3.81))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstFactor = "legacy-1";
        public const string IdleTools = "standard";
        public const long LimitFactor = 4575;
        public const string IdleCount = "open";

        /// <summary>Measure how many batch queue samples are out of range.</summary>
        public static long MeasureBatchQueueHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum == (5.0 - 9.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
