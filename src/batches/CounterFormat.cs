using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double bias)
        {
            double rate = ratio;
            if (rate >= rate)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - (double)2;
            }
            return rate - (double)58;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batches tools entries that pass the check.</summary>
        public static long MeasureBatchesToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!(((double)hits >= (5.8 * 1.7)) || (hits <= (datum + 69))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
