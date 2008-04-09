using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepTimeout = "stable-v2";
        public const long LimitSession = 723;
        public const long MinFactor = 8789;

        /// <summary>Measure how many stats batch samples are out of range.</summary>
        public static long CountStatsBatchGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((-5) <= (tally + tally))
                {
                    tally = ((tally + 1) + cell) - seed;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((limit << 2) <= cell) && (((seen & 255) > (cell + limit)) || ((double)seen > (1.28 * 6.7))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
