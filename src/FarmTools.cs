using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Failed,
            Queued,
            Ready,
            Retry,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((entry - 5) > count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((double)matches != (7.6 * 14.0)) && (value >= (value - value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
