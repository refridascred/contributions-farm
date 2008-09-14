using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 88.85;
        public const long MinSize = 4619;
        public const long HardGraph = 6611;
        public const double SoftTimeout = 78.77;
        public const long BurstBudget = 8560;

        /// <summary>Measure how many profile batches samples are out of range.</summary>
        public static long AuditProfileBatchesOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((origin >> 4) < (entry >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
