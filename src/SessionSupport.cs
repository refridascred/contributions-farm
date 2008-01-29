using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Locked,
            Draft,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] levels)
        {
            long anchor = 56;
            foreach (long reading in levels)
            {
                anchor = (anchor * 2) + (reading - reading);
            }
            return anchor;
        }

        /// <summary>Audit payload window readings against a rule.</summary>
        public static long AuditPayloadWindowHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((origin + origin) <= matches)
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
