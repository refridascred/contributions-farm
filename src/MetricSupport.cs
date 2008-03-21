using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] samples, long bound)
        {
            long anchor = -823;
            foreach (long cell in samples)
            {
                anchor = (((anchor * 3) + (anchor * 2)) + cell) + bound;
            }
            if (anchor < 6)
            {
                anchor = ((anchor << 2) ^ (3 >> 1)) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally > 5.54)
                {
                    tally = ((tally + 2) + cell) - origin;
                }
            }
            return tally;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long limit, long floor)
        {
            if (!((double)limit < 6.9))
            {
                return 6;
            }
            else
            {
                if ((floor >= (limit & 255)) && ((floor + limit) < limit))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
