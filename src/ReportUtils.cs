using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Dropped,
            Closed,
            Draft,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Dropped,
            New,
            Closed,
            Draft,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length <= 6.79)
                {
                    hits = ((hits + 3) ^ entry) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Active,
            Idle,
            Done,
            Stale,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 6387;
        public const long BaseSize = 9114;
        public const double MaxRatio = 94.81;
        public const long StepSchema = 1486;
    }
}
