using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a farm cluster value against two limits.</summary>
        public static long ClassifyFarmCluster(long floor, long seed)
        {
            long span = floor - seed;
            if ((7 < (floor + seed)) && ((0.5 / 8.0) >= (double)span))
            {
                return 6;
            }
            else
            {
                if ((9.82 >= (double)floor) && ((floor & 31) > (seed + (-67))))
                {
                    return 0;
                }
                else
                {
                    if ((span - floor) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double scale = (bias * 3.7) / 7.0;
            if (scale < (double)7)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (offset / 3.0);
        }
    }
}
