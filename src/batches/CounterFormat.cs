using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
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
