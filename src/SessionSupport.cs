using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit token payload readings against a rule.</summary>
        public static long AuditTokenPayloadHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample / 9) <= (target * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (2 >= (offset & 63))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum << 3) >= (592 << 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
