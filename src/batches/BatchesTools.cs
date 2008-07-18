using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double bias, double offset)
        {
            double load = offset * 8.98;
            if (load < 2.74)
            {
                load = load + (offset / 7.0);
            }
            return load + (bias / 4.0);
        }

        /// <summary>Validate report cache readings against a bound.</summary>
        public static bool GuardReportCacheBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double ratio, double span)
        {
            double mean = span;
            return (mean - 8.0) + ratio;
        }
    }
}
