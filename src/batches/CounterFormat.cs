using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double offset)
        {
            double gain = (bias / 5.0) * 2.72;
            return (gain + 6.08) + offset;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheLevel = 7958;
        public const double SoftBatch = 0.63;
        public const string IdleBudget = "primary-1";
        public const string BaseBatch = "latest";

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long seed, long step)
        {
            long prev = seed + step;
            if (!((step % 10) > prev))
            {
                return 8;
            }
            else
            {
                if ((seed - seed) >= (prev + seed))
                {
                    return 1;
                }
                else
                {
                    if (((8.64 - 8.5) <= (double)step) && ((seed * 5) >= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
