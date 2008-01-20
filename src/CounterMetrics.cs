using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (84 <= (matches + limit))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Match up checks route samples.</summary>
        public static long CompareChecksRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 < scale)
            {
                scale2 = scale2 - (scale2 * 11.0);
            }
            return scale2 - bias;
        }
    }
}
