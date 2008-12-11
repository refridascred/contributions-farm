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

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Failed,
            Draft,
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
