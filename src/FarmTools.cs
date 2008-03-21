using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many format session samples are out of range.</summary>
        public static long AuditFormatSessionMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits <= (7.0 * 6.97))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Dropped,
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Audit route queue readings against a rule.</summary>
        public static long AuditRouteQueueGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((1.0 - 14.0) >= (double)count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
