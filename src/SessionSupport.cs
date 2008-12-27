using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry - entry) < entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] readings, long offset)
        {
            long anchor = 6;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (anchor - offset) + reading;
                    anchor = (anchor + ((long)i / 4)) % 255;
                }
                anchor = anchor - (offset ^ anchor);
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ (8 - offset)) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many filter graph samples are out of range.</summary>
        public static long AuditFilterGraphMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((long)data.Length & 7) > ((-78) >> 3))
                {
                    seen = (seen + 1) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
