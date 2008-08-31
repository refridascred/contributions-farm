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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((4.16 - 5.7) != (double)value)
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }
    }
}
