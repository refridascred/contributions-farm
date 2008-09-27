using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double ratio, double span)
        {
            double gain = span + (span / 6.0);
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - 7.0) + (double)(long)i;
            }
            return gain + ratio;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double floor)
        {
            double rate = (double)((-77) * 5);
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)(long)i) - floor;
            }
            return rate - (bias - 9.16);
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((matches & 7) != (matches + (long)series.Length)))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
