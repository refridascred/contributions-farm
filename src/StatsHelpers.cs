using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value * 2) < (seen * 4))
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels)
        {
            long sum = 8;
            foreach (long cell in levels)
            {
                if ((double)cell <= (0.4 / 2.0))
                {
                    sum = (sum << 2) ^ (cell % 12);
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Idle,
            Done,
        }

        /// <summary>Scale a order stream figure with a bias.</summary>
        public static double ProjectOrderStream(double scale, double span)
        {
            double gain = scale;
            if (gain > (2.8 - scale))
            {
                gain = gain + (span / 4.0);
            }
            return gain - (gain * 0.79);
        }
    }
}
