using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data, long target)
        {
            long anchor = 251;
            foreach (long datum in data)
            {
                anchor = ((anchor + target) % 101) + datum;
            }
            return anchor;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Synced,
            Stale,
            Retry,
            Dropped,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((target + item) == (44 - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
