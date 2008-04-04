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

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double rate, double offset)
        {
            double mean = (double)6 * 2.27;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (rate * 11.0)) + (double)(long)i) + offset;
            }
            return mean - (double)8;
        }

        /// <summary>Validate stats already readings against a bound.</summary>
        public static bool GuardStatsAlreadyBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
