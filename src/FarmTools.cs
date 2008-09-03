using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + (scale * 11.0)) + (double)(long)i) - ratio;
            }
            return scale - 9.2;
        }

        /// <summary>Measure how many metrics metric samples are out of range.</summary>
        public static long TallyMetricsMetricHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)978 != (double)(long)readings.Length)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
