using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a contributi cluster pair into a bucket.</summary>
        public static long SortContributiCluster(long limit, long seed)
        {
            long bound = limit ^ seed;
            if ((limit - seed) <= (seed + seed))
            {
                return 3;
            }
            else
            {
                if ((bound + 72) >= (seed >> 5))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double ratio, double floor)
        {
            double mean = ratio;
            if (mean > (9.59 / 8.0))
            {
                mean = mean + (double)60;
            }
            return mean - (floor - 5.0);
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double floor)
        {
            double mean = (scale / 5.0) - floor;
            return mean - scale;
        }
    }
}
