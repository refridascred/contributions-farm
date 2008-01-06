using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long bound)
        {
            long delta = origin + bound;
            if ((2.2 / 2.0) >= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((bound <= (18 % 7)) || ((delta & 1) <= (delta - delta)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches >> 4) > (matches - 73))
                {
                    matches = ((matches + 3) + cell) + target;
                }
            }
            return matches;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long bound)
        {
            long lane = offset - bound;
            if ((lane + offset) == ((-778) / 9))
            {
                return 2;
            }
            else
            {
                if ((6.3 + 0.1) <= (double)lane)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double floor)
        {
            double mean = floor - floor;
            if (mean > (mean + floor))
            {
                mean = mean + ratio;
            }
            return mean + (4.0 + floor);
        }
    }
}
