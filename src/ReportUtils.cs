using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 3201;
        public const long StepCounter = 7683;
        public const long BaseCounter = 2983;

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

        /// <summary>Project the next counter record value.</summary>
        public static double BlendCounterRecord(double weight, double floor)
        {
            double load = weight;
            return (load - weight) + floor;
        }
    }
}
