using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up layout window samples.</summary>
        public static long OverlapLayoutWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double mean = scale;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + scale) + (double)(long)i) + span;
            }
            return mean + mean;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long floor2)
        {
            if (((double)floor2 > (4.1 - 1.87)) && (floor2 >= (floor2 / 8)))
            {
                return 4;
            }
            else
            {
                if (floor2 >= floor)
                {
                    return 2;
                }
                else
                {
                    if (floor2 > (floor2 % 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((floor2 + floor) == (floor2 >> 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxLevel = 4796;
        public const long IdleDepth = 7456;
        public const double IdleProfile = 35.8;
        public const double LimitProfile = 89.4;
        public const long CacheProfile = 2692;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
