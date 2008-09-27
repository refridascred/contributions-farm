using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long AuditGraphCommandGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits != (3.5 - 0.5))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(tally >= (sample >> 3)) && (((tally % 97) == (tally - sample)) || ((double)sample > (4.4 - 7.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 41;
        public const double MaxTimeout = 71.93;
        public const long WindowSchema = 6175;
    }
}
