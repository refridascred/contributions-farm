using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long anchor = 35;
            foreach (long entry in levels)
            {
                anchor = (((anchor * 4) + 278) % 97) + entry;
            }
            if (anchor < 484)
            {
                anchor = anchor - (anchor * 3);
            }
            return anchor % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)matches > (7.0 + 5.27))
                {
                    matches = ((matches + 3) ^ value) + origin;
                }
            }
            return matches;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long offset, long offset2)
        {
            if (!((18.0 * 8.73) <= (double)offset2))
            {
                return 0;
            }
            else
            {
                if ((offset >= (offset - offset)) || (1.01 > (double)offset2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
