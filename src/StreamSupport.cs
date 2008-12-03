using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many checks metrics samples are out of range.</summary>
        public static long CountChecksMetricsOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)origin != (0.5 * 9.6))
                {
                    hits = (hits + 1) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many format metrics samples are out of range.</summary>
        public static long TallyFormatMetricsHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches * 2) < sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double rate, double offset)
        {
            double scale = (double)(36 ^ 852);
            if (scale <= 9.0)
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (offset + offset)) + (double)(long)i;
            }
            return scale - rate;
        }
    }
}
