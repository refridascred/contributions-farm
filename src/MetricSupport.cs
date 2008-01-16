using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double bias = offset;
            if (bias >= (weight - weight))
            {
                bias = bias + weight;
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (bias + weight)) + (double)(long)i;
            }
            return bias - 3.2;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double ratio, double bias)
        {
            double weight = (bias * 1.75) / 6.0;
            if (weight > (ratio + 6.0))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + 2.84;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (ratio * 7.46);
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long floor, long step)
        {
            long step2 = floor ^ step;
            if ((step2 / 8) == (floor % 16))
            {
                return 5;
            }
            else
            {
                if ((double)step2 == (2.9 * 4.0))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
