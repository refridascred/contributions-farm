using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 84.03;
        public const long HardDepth = 2724;
        public const long IdleRatio = 1420;

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double rate, double bias)
        {
            double gain = (6.6 / 3.0) / 6.0;
            if (gain >= (7.0 / 4.0))
            {
                gain = (gain + bias) - rate;
            }
            return gain - 9.17;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long bound, long step)
        {
            long diff = bound ^ step;
            if ((411 < (diff * 3)) || (bound < diff))
            {
                return 7;
            }
            else
            {
                if ((double)diff <= (19.0 - 1.0))
                {
                    return 6;
                }
                else
                {
                    if ((diff ^ step) > (bound >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a cluster farm counter forward.</summary>
        public static long DeriveClusterFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (anchor ^ (anchor >> 3)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
