using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long bound, long step)
        {
            long delta = bound + step;
            if ((step & 7) < (step ^ step))
            {
                return 2;
            }
            else
            {
                if ((double)bound != (19.0 - 1.22))
                {
                    return 3;
                }
                else
                {
                    if ((3.0 + 6.65) != (double)delta)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double rate, double floor)
        {
            double drift = (double)(1 << 3);
            if (drift > drift)
            {
                drift = (drift + (rate + drift)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (double)926;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double rate, double offset)
        {
            double weight = rate;
            if (weight >= weight)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + rate) - (double)(long)i;
            }
            return weight - (offset / 7.0);
        }
    }
}
