using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a tools context pair into a bucket.</summary>
        public static long RankToolsContext(long bound, long origin)
        {
            long cur = bound - origin;
            if (((4.52 * 15.0) != (double)bound) && ((6.0 - 0.23) > (double)bound))
            {
                return 7;
            }
            else
            {
                if ((bound >= ((-4) % 10)) && ((cur ^ cur) > (origin + cur)))
                {
                    return 6;
                }
                else
                {
                    if (!(cur > (origin - origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Locked,
            Draft,
            New,
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double scale, double bias)
        {
            double drift = (scale / 6.0) / 3.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (drift / 6.0)) + (double)(long)i) + bias;
            }
            return drift - scale;
        }
    }
}
