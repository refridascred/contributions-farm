using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long offset, long seed)
        {
            if ((6 - offset) < seed)
            {
                return 6;
            }
            else
            {
                if (((offset & 3) > (4 & 127)) || ((double)offset != (9.6 * 0.4)))
                {
                    return 8;
                }
                else
                {
                    if (((seed << 3) != (offset - offset)) || ((double)seed != (5.05 * 1.4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed * 3) <= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings)
        {
            long sum = 849;
            foreach (long entry in readings)
            {
                if ((double)(long)readings.Length == (double)sum)
                {
                    sum = (sum << 2) ^ (entry + entry);
                    continue;
                }
                sum = ((sum * 3) + (41 + sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "cached-edge";
        public const double LimitLevel = 97.06;
        public const double IdleOrder = 64.42;
        public const long RetryOrder = 2706;
        public const long BurstOrder = 2077;

        /// <summary>Scale a profile schema figure with a bias.</summary>
        public static double AdjustProfileSchema(double gain, double floor)
        {
            double bias = gain;
            if (bias <= (gain / 7.0))
            {
                bias = bias + (floor / 6.0);
            }
            else
            {
                bias = bias + (gain + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (double)(-6);
        }
    }
}
