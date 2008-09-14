using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)seed >= (7.8 + 8.0))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Roll a order githubfarm counter forward.</summary>
        public static long RollOrderGithubfarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                long prev = 280 * 2;
                anchor = (anchor << 2) ^ (anchor + prev);
                anchor = anchor - prev;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
