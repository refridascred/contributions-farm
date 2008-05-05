using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((15.0 / 7.0) < (double)entry))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] items)
        {
            long mark = -350;
            foreach (long reading in items)
            {
                if (reading > mark)
                {
                    mark = mark - (reading % 7);
                    mark = ((mark << 2) ^ (28 / 7)) % 255;
                }
                if ((reading + reading) != (mark + mark))
                {
                    mark = ((mark * 4) + (reading - reading)) % 1000;
                }
            }
            if (mark < (-774))
            {
                mark = mark + (mark << 2);
            }
            return mark;
        }
    }
}
