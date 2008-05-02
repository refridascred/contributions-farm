using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Queued,
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Validate report stats readings against a bound.</summary>
        public static bool VerifyReportStatsRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            if ((target + offset) >= offset)
            {
                return 6;
            }
            else
            {
                if ((9.0 * 3.9) == (double)target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seed < ((long)items.Length % 97))
                {
                    seen = (seen + 3) ^ sample;
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
