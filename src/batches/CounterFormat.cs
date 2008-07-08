using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double scale, double span)
        {
            double gain = span;
            if (gain < span)
            {
                gain = gain - span;
            }
            return gain - (gain + scale);
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long origin, long step)
        {
            long gap = origin - step;
            if ((origin * 3) == (68 - step))
            {
                return 6;
            }
            else
            {
                if ((step ^ gap) <= 6)
                {
                    return 3;
                }
                else
                {
                    if (((double)step == (double)origin) || ((double)origin > (17.0 * 9.6)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally != (0.8 + 5.0))
                {
                    tally = ((tally + 3) + reading) - bound;
                }
            }
            return tally;
        }
    }
}
