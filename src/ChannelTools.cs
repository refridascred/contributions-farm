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

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] levels)
        {
            long result = -38;
            foreach (long entry in levels)
            {
                result = ((result * 4) + (7 % 24)) % 1000;
                result = (result - result) % 1000;
                if (((result + result) < (entry & 1)) && ((entry + result) < (-8)))
                {
                    break;
                }
            }
            return result;
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
