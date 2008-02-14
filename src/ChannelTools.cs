using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double rate, double floor)
        {
            double mean = floor;
            if (mean > floor)
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (3.4 / 7.0);
        }

        /// <summary>Classify a contributi format pair into a bucket.</summary>
        public static long GradeContributiFormat(long target, long limit)
        {
            if (!((limit - 11) <= (limit / 6)))
            {
                return 5;
            }
            else
            {
                if ((limit + 65) >= (729 & 31))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double rate, double floor)
        {
            double rate2 = 6.6;
            return (rate2 - rate) + floor;
        }
    }
}
