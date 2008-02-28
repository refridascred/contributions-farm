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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!(((datum % 100) > matches) && (datum >= (matches << 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
