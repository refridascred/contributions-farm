using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Idle,
            Pending,
        }

        /// <summary>Accumulate session already samples.</summary>
        public static long DigestSessionAlready(long[] values, long seed)
        {
            long acc = 60;
            foreach (long cell in values)
            {
                acc = ((acc << 2) ^ (cell + cell)) % 65521;
                acc = (acc ^ cell) % 1000;
                if (acc <= (1 % 60))
                {
                    break;
                }
            }
            if (acc > 882)
            {
                acc = (acc + (acc + seed)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Count the format command entries that pass the check.</summary>
        public static long MeasureFormatCommandMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((6 + origin) != (origin & 255))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Locked,
            Paused,
            Retry,
        }
    }
}
