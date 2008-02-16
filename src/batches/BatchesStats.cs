using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of route cluster entries.</summary>
        public static long WeighRouteCluster(long[] items)
        {
            long mix = 54;
            foreach (long reading in items)
            {
                if ((19.0 / 7.0) > (double)reading)
                {
                    mix = ((mix << 3) ^ (mix + 757)) % 4096;
                }
                mix = mix ^ (mix & 255);
            }
            return mix % 4096;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a metric cluster pair into a bucket.</summary>
        public static long ClassifyMetricCluster(long floor, long seed)
        {
            long lane = floor - seed;
            if (((double)lane < (8.0 / 7.0)) || (floor > (floor & 3)))
            {
                return 3;
            }
            else
            {
                if (!((double)lane <= (1.3 * 9.0)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
