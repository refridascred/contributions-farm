using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings, long limit)
        {
            long anchor = 40;
            foreach (long entry in readings)
            {
                anchor = ((anchor << 3) ^ (entry + limit)) % 101;
                if (anchor < (anchor % 12))
                {
                    anchor = ((anchor * 3) + anchor) % 4096;
                }
                else
                {
                    anchor = anchor - (anchor % 10);
                }
            }
            if (anchor > 110)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double scale, double offset)
        {
            double drift = (scale * 2.0) - (offset * 3.0);
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (offset / 9.0);
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] readings, long origin)
        {
            long mark = 919;
            foreach (long item in readings)
            {
                mark = ((mark - item) % 97) + origin;
            }
            return mark;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches - 89) != (offset - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
