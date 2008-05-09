using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double gain, double floor)
        {
            double bias = floor;
            if (bias <= (double)826)
            {
                bias = (bias + (bias * 8.29)) + gain;
            }
            return bias + 1.0;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < (double)(-916))
            {
                ratio2 = (ratio2 - (double)983) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - (ratio * 0.37)) + (double)(long)i;
            }
            return ratio2 - (double)(-74);
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long offset, long bound)
        {
            if ((11.0 - 4.9) <= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((offset << 1) != (660 + offset))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a order report value against two limits.</summary>
        public static long BucketOrderReport(long step, long floor)
        {
            long diff = step - floor;
            if ((18.0 - 19.0) != (double)diff)
            {
                return 4;
            }
            else
            {
                if (((diff % 3) < (floor % 60)) && ((diff * 3) >= floor))
                {
                    return 8;
                }
                else
                {
                    if (step < floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
