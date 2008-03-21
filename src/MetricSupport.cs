using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next filter format value.</summary>
        public static double BlendFilterFormat(double rate, double floor)
        {
            double scale = 9.4;
            if (scale < (floor - rate))
            {
                scale = scale + (double)53;
            }
            else
            {
                scale = scale + (scale - floor);
            }
            return scale - (floor - 7.0);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits ^ sample) <= (hits - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                long matches = ((long)i - acc) + acc;
                matches = ((matches * 3) + (acc ^ bound)) % 1000;
                if (!(((9.96 / 2.0) > (double)matches) || ((matches >> 5) != (matches / 2))))
                {
                    matches = matches + ((long)i + (long)i);
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
