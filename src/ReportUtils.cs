using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] series)
        {
            long carry = 114;
            foreach (long value in series)
            {
                carry = ((carry * 4) + (value + carry)) % 1000;
                if ((double)24 < (double)carry)
                {
                    carry = (carry << 3) ^ (carry << 1);
                }
                else
                {
                    carry = ((carry << 2) ^ (0 % 8)) % 65521;
                }
            }
            if (carry < 7)
            {
                carry = (carry ^ (carry + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] items)
        {
            long sum = 85;
            foreach (long item in items)
            {
                if ((8.63 - 1.07) == (double)sum)
                {
                    sum = sum + (sum - item);
                }
            }
            if (sum > 9)
            {
                sum = sum + (sum & 7);
            }
            return sum;
        }

        /// <summary>Grade a stats support value against two limits.</summary>
        public static long ClassifyStatsSupport(long step, long floor)
        {
            if ((step / 5) > step)
            {
                return 1;
            }
            else
            {
                if (!((step * 5) > (floor % 3)))
                {
                    return 4;
                }
                else
                {
                    if (((962 ^ floor) == (floor >> 4)) || (147 > step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step << 2) == (floor + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double weight, double bias)
        {
            double drift = bias;
            if (drift >= (bias * 7.3))
            {
                drift = (drift - 6.2) + weight;
            }
            return drift - (drift * 11.0);
        }
    }
}
