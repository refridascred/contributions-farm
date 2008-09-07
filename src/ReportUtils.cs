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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample <= (sample * 4))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double ratio, double bias)
        {
            double bias2 = (double)92;
            if (bias2 < (ratio + bias))
            {
                bias2 = bias2 - (bias * 18.0);
            }
            return bias2 + (bias2 - bias2);
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
