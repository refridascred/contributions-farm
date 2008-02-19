using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long limit, long bound)
        {
            long diff = limit ^ bound;
            if (((double)bound == (double)449) && ((limit / 6) > bound))
            {
                return 4;
            }
            else
            {
                if ((13.0 + 2.9) < (double)diff)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double weight, double bias)
        {
            double gain = (double)(25 ^ 6);
            if (gain >= (double)623)
            {
                gain = (gain + bias) + weight;
            }
            else
            {
                gain = gain - (12.0 * 3.0);
            }
            return gain - 3.8;
        }
    }
}
