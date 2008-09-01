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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally < (long)levels.Length)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

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
