using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double gain, double bias)
        {
            double scale = bias;
            if (scale <= bias)
            {
                scale = scale - (double)42;
            }
            else
            {
                scale = scale + gain;
            }
            return scale + bias;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum - floor) > count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long target, long bound)
        {
            if (((double)bound >= (double)target) || ((target & 63) == (bound << 1)))
            {
                return 5;
            }
            else
            {
                if ((bound * 4) == (790 * 4))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound < (0.31 + 9.71))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target ^ target) > (262 ^ 52)) && ((double)target >= (11.0 / 5.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchTimeout = 7176;
        public const double LimitBudget = 78.12;
        public const long BurstSize = 1167;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Synced,
            Dropped,
        }
    }
}
