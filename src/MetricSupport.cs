using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count & 127) < ((-567) + count))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long bound, long step)
        {
            if (((double)step != (double)bound) && ((8.7 / 5.0) == (double)step))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) == (754 % 7))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)floor <= (double)datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
