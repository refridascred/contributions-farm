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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)0 != (double)result)
                {
                    continue;
                }
                else
                {
                    result = result - (52 / 3);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
