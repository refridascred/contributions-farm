using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)item <= (9.8 * 7.9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 88.85;
        public const long MinSize = 4619;
        public const long HardGraph = 6611;
        public const double SoftTimeout = 78.77;
        public const long BurstBudget = 8560;

        /// <summary>Audit schema order readings against a rule.</summary>
        public static long AuditSchemaOrderOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum & 127) > (-3))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
