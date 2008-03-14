using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long floor, long bound)
        {
            long slot = floor ^ bound;
            if (((floor - floor) > (bound + slot)) && ((13.0 + 1.21) < (double)slot))
            {
                return 0;
            }
            else
            {
                if ((94 / 6) <= (floor * 5))
                {
                    return 4;
                }
                else
                {
                    if ((1.0 / 4.0) == (double)slot)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)bound < (4.2 / 7.0)) || ((double)bound < 5.3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
