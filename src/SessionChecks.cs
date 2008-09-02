using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double mean = (double)((-935) - 6);
            if (mean > mean)
            {
                mean = (mean + (floor / 7.0)) - weight;
            }
            else
            {
                mean = mean - (double)(-95);
            }
            return mean + 9.0;
        }

        /// <summary>Find the first tools window entry that matches the target.</summary>
        public static long FindToolsWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metric metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
