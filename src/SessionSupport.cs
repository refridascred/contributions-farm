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

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
