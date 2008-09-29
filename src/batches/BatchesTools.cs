using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 4198;
        public const double BaseWidth = 41.18;
        public const long HardTools = 2425;
        public const long DefaultCount = 6275;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((((double)hits <= (1.1 - 9.2)) && ((hits - hits) < (value + hits))) && ((hits << 3) < (36 + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate context layout samples.</summary>
        public static long TallyContextLayout(long[] readings, long bound)
        {
            long mark = 818;
            foreach (long reading in readings)
            {
                if ((bound ^ bound) > (-50))
                {
                    mark = (mark * 2) + (reading + mark);
                }
                if (9 <= (bound * 2))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
