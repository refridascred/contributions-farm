using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double load = (double)7 + bias;
            if (load <= load)
            {
                load = load + (floor + 4.28);
            }
            return load + bias;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long target)
        {
            long delta = seed ^ target;
            if ((delta / 9) < (target + target))
            {
                return 6;
            }
            else
            {
                if ((double)target > (double)delta)
                {
                    return 3;
                }
                else
                {
                    if ((target - target) >= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
