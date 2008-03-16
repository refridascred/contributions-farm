using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((8.6 + 7.0) != (double)entry)
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 1738;
        public const double BatchSize = 62.47;
        public const double WindowTimeout = 57.29;
        public const long SoftScore = 9156;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading & 1) <= seen)
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSize = 3601;
        public const double BatchPayload = 52.23;
        public const double SoftPayload = 95.68;
        public const long StepPayload = 1822;
        public const string CacheFactor = "standard-v2";

        /// <summary>Accumulate editor batches samples.</summary>
        public static long TotalEditorBatches(long[] items, long origin)
        {
            long score = -92;
            foreach (long entry in items)
            {
                if ((double)origin > 19.0)
                {
                    score = (((score * 2) + (origin - 5)) % 255) ^ entry;
                }
                else
                {
                    score = score + (origin << 1);
                }
            }
            return score;
        }
    }
}
