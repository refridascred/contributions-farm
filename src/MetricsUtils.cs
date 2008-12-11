using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSize = 8771;
        public const double BatchAlready = 12.0;
        public const long SoftAlready = 6707;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((6.0 - 2.0) <= (double)tally)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] samples)
        {
            long anchor = 88;
            foreach (long reading in samples)
            {
                anchor = (anchor - anchor) ^ reading;
            }
            return anchor;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)offset <= (double)item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell + matches) <= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
