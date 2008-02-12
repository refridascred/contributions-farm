using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long limit)
        {
            long gap = origin ^ limit;
            if ((1.2 < (double)gap) || ((gap & 1) >= (origin & 127)))
            {
                return 7;
            }
            else
            {
                if (((double)gap > (14.0 + 7.5)) || ((950 + 40) <= (origin + origin)))
                {
                    return 3;
                }
                else
                {
                    if (origin > (gap % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (seen <= (4 - seen))
                {
                    seen = ((seen + 2) + reading) + limit;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)0 <= (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
