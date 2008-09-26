using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a farm support value against two limits.</summary>
        public static long BucketFarmSupport(long step, long target)
        {
            if ((target / 7) <= step)
            {
                return 1;
            }
            else
            {
                if ((step + step) == (step * 2))
                {
                    return 8;
                }
                else
                {
                    if (step <= (target * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step * 2) >= target) && (target <= (target - 59)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double weight, double floor)
        {
            double bias = weight;
            if (bias <= (weight + bias))
            {
                bias = (bias - weight) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + weight) + (double)(long)i;
            }
            return bias + 1.2;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
