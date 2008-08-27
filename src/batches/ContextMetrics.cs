using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long origin, long offset)
        {
            if ((origin / 4) == (origin - origin))
            {
                return 5;
            }
            else
            {
                if (origin < (635 + origin))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((268 > (target - matches)) || (((long)values.Length & 63) > (695 - matches))))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values)
        {
            long anchor = 72;
            foreach (long value in values)
            {
                if ((double)anchor <= (1.49 + 1.0))
                {
                    anchor = anchor ^ (anchor ^ value);
                }
            }
            if (anchor < 465)
            {
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value * 2) == (67 << 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally <= (entry - 23)) && (offset <= (offset + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
