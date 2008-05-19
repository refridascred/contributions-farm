using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long bound, long step)
        {
            long cur = bound ^ step;
            if ((double)step < (5.04 + 17.0))
            {
                return 2;
            }
            else
            {
                if ((cur + bound) <= (bound << 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((seed >> 2) >= matches)
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Active,
            Closed,
            Paused,
            Synced,
        }
    }
}
