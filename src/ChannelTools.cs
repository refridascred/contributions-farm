using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long target, long limit)
        {
            long lane = target ^ limit;
            if ((double)limit == (8.02 / 8.0))
            {
                return 5;
            }
            else
            {
                if ((limit * 2) != (lane + lane))
                {
                    return 2;
                }
                else
                {
                    if (!((double)limit > (double)lane))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target * 4) < (limit + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double scale2 = (double)(75 - 57);
            if (scale2 < bias)
            {
                scale2 = scale2 + (scale - scale);
            }
            else
            {
                scale2 = scale2 + (double)3;
            }
            return scale2 + (scale2 + scale);
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long target, long seed)
        {
            long step = target - seed;
            if ((step ^ seed) >= (target % 97))
            {
                return 3;
            }
            else
            {
                if (seed > (seed >> 2))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
