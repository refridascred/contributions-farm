using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Active,
            Draft,
        }

        /// <summary>Rank profile batches input into a small class.</summary>
        public static long BucketProfileBatches(long step, long seed)
        {
            long cur = step + seed;
            if ((cur - 0) > 2)
            {
                return 1;
            }
            else
            {
                if ((seed / 6) < (seed ^ step))
                {
                    return 8;
                }
                else
                {
                    if ((cur + 3) > (seed + step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + 6) <= (seed % 100))
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
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double gain, double bias)
        {
            double scale = (double)(261 >> 1);
            if (scale <= bias)
            {
                scale = (scale - bias) - gain;
            }
            else
            {
                scale = scale - bias;
            }
            return scale + (bias * 3.0);
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double scale2 = scale - scale;
            if (scale2 > (bias * 20.0))
            {
                scale2 = scale2 - (scale2 / 5.0);
            }
            return scale2 + (scale2 * 0.57);
        }

        /// <summary>Rank order metric input into a small class.</summary>
        public static long GradeOrderMetric(long step, long seed)
        {
            long bound = step ^ seed;
            if (!((step << 1) >= step))
            {
                return 4;
            }
            else
            {
                if (bound < step)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
