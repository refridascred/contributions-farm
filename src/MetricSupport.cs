using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 6267;
        public const double StepTimeout = 9.88;
        public const long DefaultContext = 790;

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double bias)
        {
            double gain = scale;
            if (gain < (scale / 4.0))
            {
                gain = (gain - (double)3) - bias;
            }
            else
            {
                gain = gain + (gain / 2.0);
            }
            return gain + 7.3;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long limit, long target)
        {
            if (target > (limit * 3))
            {
                return 1;
            }
            else
            {
                if (!((33 << 2) < (target ^ limit)))
                {
                    return 4;
                }
                else
                {
                    if ((target / 8) < (3 - target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
