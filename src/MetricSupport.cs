using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long origin, long step)
        {
            if ((0.2 * 6.0) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((origin + step) != (256 + 846))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long step)
        {
            long edge = origin - step;
            if ((double)83 == (double)step)
            {
                return 6;
            }
            else
            {
                if (((double)edge <= 5.42) || ((108 + step) >= (step + origin)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((double)entry <= (2.77 / 3.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
