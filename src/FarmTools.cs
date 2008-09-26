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

        /// <summary>Roll a profile record counter forward.</summary>
        public static long SeriesProfileRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = total ^ (offset ^ offset);
                total = ((total * 2) + (offset % 5)) % 65521;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
