using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long target)
        {
            if ((bound - bound) != (target + bound))
            {
                return 0;
            }
            else
            {
                if (!((bound + 0) <= bound))
                {
                    return 6;
                }
                else
                {
                    if ((target - bound) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 3) != (bound << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - (weight / 3.0)) + (double)(long)i) + gain;
            }
            return weight + weight;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
