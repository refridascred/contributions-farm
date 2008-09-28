using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
