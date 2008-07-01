using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double weight, double floor)
        {
            double gain = (floor + 3.2) - (weight / 6.0);
            if (gain < floor)
            {
                gain = gain - (weight * 4.75);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (4.0 * 7.9)) + (double)(long)i;
            }
            return gain + (double)907;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchSpan = 3627;
        public const double HardCount = 67.64;
        public const long BatchLevel = 6328;

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long limit)
        {
            if ((62 + limit) == (limit << 3))
            {
                return 2;
            }
            else
            {
                if ((step & 1) <= (limit ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((step / 2) == (step ^ limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step & 1) >= 1)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
