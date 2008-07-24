using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((0.29 + 2.8) <= (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 8419;
        public const long BatchBudget = 5174;
        public const double BaseWidth = 93.42;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen & 31) >= ((long)series.Length + target))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
