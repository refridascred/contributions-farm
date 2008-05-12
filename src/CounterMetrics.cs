using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the stats metric series from a seed.</summary>
        public static long SeriesStatsMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                if (0.8 <= (double)seed)
                {
                    mix = ((mix << 2) ^ 26) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 < bias)
            {
                ratio2 = (ratio2 - bias) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + (ratio2 - ratio2)) - (double)(long)i;
            }
            return ratio2 + (double)8;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!(((3.0 - 4.2) == (double)step) || ((double)hits == (13.0 / 7.0))))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
