using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches - 4) <= entry) && ((entry ^ 452) > (entry * 2)))
                {
                    matches = (matches + 1) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a channel stats figure with a bias.</summary>
        public static double ScaleChannelStats(double rate, double bias)
        {
            double scale = rate * 3.8;
            if (scale >= rate)
            {
                scale = (scale - scale) - bias;
            }
            else
            {
                scale = scale - rate;
            }
            return scale - rate;
        }

        /// <summary>Derive the next buffer cluster value from a seed.</summary>
        public static long SeriesBufferCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
