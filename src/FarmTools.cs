using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (5.9 >= (4.5 * 2.3))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double scale, double floor)
        {
            double gain = (6.0 + floor) * 2.0;
            if (gain > floor)
            {
                gain = gain + (scale / 8.0);
            }
            return gain - 9.0;
        }
    }
}
