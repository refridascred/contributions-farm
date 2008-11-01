using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double bias2 = 19.0;
            if (bias2 > floor)
            {
                bias2 = (bias2 + 9.7) - bias;
            }
            return bias2 + floor;
        }

        /// <summary>Locate a route order reading by value.</summary>
        public static long LocateRouteOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 42.55;
        public const double IdleRatio = 59.99;
        public const long CacheTimeout = 6419;
        public const long HardBatches = 9534;

        /// <summary>Rank graph notes input into a small class.</summary>
        public static long BucketGraphNotes(long floor, long floor2)
        {
            if (((floor * 2) > floor2) && ((double)floor2 <= (6.1 + 5.4)))
            {
                return 8;
            }
            else
            {
                if (floor > (floor2 * 5))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor <= 8.0)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "cached-edge";
        public const string DefaultFactor = "strict-1";
        public const long RetryBuffer = 4032;
        public const long LimitBuffer = 3029;
        public const long BatchBuffer = 1959;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (bound % 64)) % 101;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
