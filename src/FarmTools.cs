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

        /// <summary>Validate profile route readings against a bound.</summary>
        public static bool CheckProfileRouteRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
