using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultCount = 68.93;
        public const string BatchInterval = "primary-1";
        public const long BatchBudget = 2198;
        public const long StepBatch = 9665;
        public const long BaseBatch = 6380;

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 3894;
        public const double HardTimeout = 74.9;
        public const double LimitSize = 6.51;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits < (hits ^ cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
