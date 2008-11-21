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

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double gain = 7.0;
            if (gain > (double)50)
            {
                gain = (gain + (rate - gain)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (double)(-41);
        }
    }
}
