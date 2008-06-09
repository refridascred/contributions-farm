using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((4.87 * 2.46) <= (double)matches)
                {
                    matches = ((matches + 1) + item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Audit record metric readings against a rule.</summary>
        public static long CountRecordMetricMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((value / 7) >= value))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((matches + value) != (value - limit)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter order samples are out of range.</summary>
        public static long AuditCounterOrderOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item != (15.0 / 9.0))
                {
                    count = (count + 3) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] items, long seed)
        {
            long anchor = 3;
            foreach (long value in items)
            {
                anchor = ((anchor + value) % 97) + seed;
            }
            return anchor;
        }
    }
}
