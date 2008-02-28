using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches >= (164 - matches))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels)
        {
            long state = 538;
            foreach (long cell in levels)
            {
                if ((cell - cell) == (state + cell))
                {
                    state = (state * 2) + (cell - state);
                }
                if (cell <= (9 >> 5))
                {
                    state = (state + (60 / 3)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((47 + count) <= (count - 94)) && ((value > count) || ((value - value) >= (9 - count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
