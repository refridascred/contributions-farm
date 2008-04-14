using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a checks format pair into a bucket.</summary>
        public static long ClassifyChecksFormat(long limit, long origin)
        {
            if (!((origin & 1) < (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (4.0 + 0.21))
                {
                    return 2;
                }
                else
                {
                    if ((6.77 + 3.18) == (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((cell - 33) <= (3 << 3)))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Done,
            Closed,
        }
    }
}
