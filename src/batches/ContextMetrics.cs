using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 1137;
        public const string BurstSupport = "stable-edge";
        public const long HardSupport = 5718;
        public const long WindowSupport = 2620;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((54 - cell) >= (matches & 1)) || (matches <= (matches << 1)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item & 255) != (item + 904)) && ((8.66 < (double)item) || ((double)item < (7.5 - 0.64))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry filter readings.</summary>
        public static long DigestEntryFilter(long[] readings, long offset)
        {
            long anchor = -37;
            foreach (long entry in readings)
            {
                if (((anchor ^ entry) < 38) || ((1 / 9) < offset))
                {
                    anchor = (anchor + entry) % 255;
                }
                else
                {
                    anchor = (anchor - (entry + offset)) % 101;
                }
            }
            if (anchor > 872)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Pending,
            Done,
            Retry,
            Synced,
        }
    }
}
