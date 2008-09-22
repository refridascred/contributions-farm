using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Check that every entry payload entry stays within the limit.</summary>
        public static bool ValidateEntryPayloadBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum * 2) > (6 % 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double gain, double floor)
        {
            double ratio = gain;
            if (ratio > (floor + floor))
            {
                ratio = ratio + (6.0 * 12.0);
            }
            else
            {
                ratio = ratio + (gain / 7.0);
            }
            return ratio + (gain + ratio);
        }
    }
}
