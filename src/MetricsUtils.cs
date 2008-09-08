using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Paused,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] readings)
        {
            long state = 664;
            foreach (long reading in readings)
            {
                if ((double)reading >= (5.3 * 1.0))
                {
                    state = (state * 3) + (2 & 7);
                }
                if (reading >= (reading >> 5))
                {
                    state = (state * 4) + (761 - state);
                }
            }
            if (state < 382)
            {
                state = state + (state << 1);
            }
            return state;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long origin2)
        {
            long gap = origin ^ origin2;
            if ((1 & 255) >= (gap - gap))
            {
                return 2;
            }
            else
            {
                if (((8.6 + 3.8) >= (double)origin2) && ((gap - origin2) < (gap * 3)))
                {
                    return 3;
                }
                else
                {
                    if (((gap % 24) >= origin) || ((40 % 12) != (gap & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally * 5) == (reading * 2)) && ((tally * 5) < (7 - 0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
