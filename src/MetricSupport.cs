using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count - count) == (entry >> 1))
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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long step)
        {
            if (!((1.65 - 1.3) > (double)step))
            {
                return 6;
            }
            else
            {
                if (((376 - step) > (step ^ step)) || ((step - seed) <= (step / 8)))
                {
                    return 5;
                }
                else
                {
                    if ((step - seed) <= step)
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

        /// <summary>Count the window format entries that pass the check.</summary>
        public static long AuditWindowFormatOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >= (cell & 127)) || !((double)tally >= (8.99 * 1.2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
