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

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values)
        {
            long carry = 79;
            foreach (long cell in values)
            {
                if (cell >= (carry - carry))
                {
                    carry = (carry ^ 6) % 65521;
                }
                else
                {
                    carry = carry + (8 ^ cell);
                }
                if ((carry % 5) < (cell - cell))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstWidth = 58.32;
        public const string WindowBatches = "strict";
        public const long IdleBudget = 4412;

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
