using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long limit, long origin)
        {
            long lane = limit + origin;
            if (((14 - limit) > (626 >> 4)) || ((23 % 24) < (limit >> 2)))
            {
                return 5;
            }
            else
            {
                if ((limit / 3) != (lane % 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank order graph input into a small class.</summary>
        public static long ClassifyOrderGraph(long seed, long origin)
        {
            if (seed <= (77 << 2))
            {
                return 0;
            }
            else
            {
                if (17.0 >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Owner { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }
    }
}
