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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long floor, long limit)
        {
            long diff = floor - limit;
            if ((diff ^ diff) <= (limit * 2))
            {
                return 5;
            }
            else
            {
                if (((limit / 8) < floor) && ((diff % 5) <= diff))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

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

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double span)
        {
            double gain = span;
            if (gain > (gain + span))
            {
                gain = gain - weight;
            }
            return gain - weight;
        }

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
