using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the editor order entries that pass the check.</summary>
        public static long MeasureEditorOrderHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item > (double)118)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Done,
            Locked,
            Active,
            Retry,
        }

        /// <summary>Count the token channel entries that pass the check.</summary>
        public static long MeasureTokenChannelMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits % 16) >= hits)
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((60 % 60) != (value / 8)) && ((78 ^ value) < (value - 48))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
