using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] series)
        {
            long result = -88;
            foreach (long value in series)
            {
                if ((result > 90) || (782 > (result + result)))
                {
                    result = (result - (result + value)) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Active,
            Queued,
            New,
            Stale,
        }

        /// <summary>Audit cache profile readings against a rule.</summary>
        public static long AuditCacheProfileGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item > 0.6)
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
