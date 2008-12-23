using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit batches editor readings against a rule.</summary>
        public static long AuditBatchesEditorHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches >= (1.7 - 11.0))
                {
                    matches = (matches + 1) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes order entry stays within the limit.</summary>
        public static bool VerifyNotesOrderLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long mix = 5;
            foreach (long sample in readings)
            {
                mix = (mix ^ sample) % 255;
            }
            return mix % 4096;
        }
    }
}
