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
