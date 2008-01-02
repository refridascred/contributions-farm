using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits >= (hits * 2))
                {
                    hits = ((hits + 2) ^ item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate metric route readings against a bound.</summary>
        public static bool GuardMetricRouteLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] samples, long offset)
        {
            long total = 324;
            foreach (long cell in samples)
            {
                if (!((cell << 2) < (cell % 5)))
                {
                    total = total + (offset >> 1);
                }
                if (offset <= (682 ^ 17))
                {
                    total = total + total;
                }
                else
                {
                    total = ((total * 4) + (offset ^ total)) % 4096;
                }
            }
            return total;
        }
    }
}
