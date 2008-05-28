using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - (7.0 - rate)) + (double)(long)i) - bias;
            }
            return gain + (gain / 4.0);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long origin, long target)
        {
            if ((target >> 3) > target)
            {
                return 4;
            }
            else
            {
                if (((83 - 19) >= (origin >> 3)) || ((target - target) <= target))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long offset)
        {
            if ((double)offset < (4.05 * 7.76))
            {
                return 0;
            }
            else
            {
                if ((seed >> 1) < (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= 1.61)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
