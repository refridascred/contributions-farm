using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double ratio, double floor)
        {
            double gain = floor;
            if (gain <= (gain - gain))
            {
                gain = (gain + (double)108) - ratio;
            }
            return gain + (4.0 * 10.0);
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(((1 - reading) <= (seen % 10)) && (offset > reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (limit <= matches)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
