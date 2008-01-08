using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a metric commits value against two limits.</summary>
        public static long GradeMetricCommits(long bound, long seed)
        {
            long gap = bound - seed;
            if (!((seed + (-34)) < (gap + gap)))
            {
                return 8;
            }
            else
            {
                if (gap < 9)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double ratio = rate + floor;
            if (ratio <= (floor + rate))
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio - (ratio * 7.0);
            }
            return ratio + (rate + floor);
        }
    }
}
