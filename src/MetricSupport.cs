using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a report filter pair into a bucket.</summary>
        public static long GradeReportFilter(long limit, long floor)
        {
            if ((limit + limit) == (floor + limit))
            {
                return 7;
            }
            else
            {
                if (((16.0 / 6.0) < (double)floor) && ((limit + limit) == (floor - limit)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the context queue entries that pass the check.</summary>
        public static long MeasureContextQueueGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((double)392 < (double)hits))
                {
                    hits = ((hits + 1) ^ sample) - step;
                }
            }
            return hits;
        }
    }
}
