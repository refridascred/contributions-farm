using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every payload report entry stays within the limit.</summary>
        public static bool GuardPayloadReportRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many graph counter samples are out of range.</summary>
        public static long CountGraphCounterMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((seed - hits) != (hits & 3))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double ratio, double floor)
        {
            double scale = 5.6;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (double)(long)i) - floor;
            }
            return scale + (ratio / 3.0);
        }
    }
}
