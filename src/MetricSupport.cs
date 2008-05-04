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

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long step2)
        {
            long prev = step + step2;
            if ((step ^ step2) <= (step - step))
            {
                return 8;
            }
            else
            {
                if (!((double)prev >= (4.38 * 7.0)))
                {
                    return 4;
                }
                else
                {
                    return 6;
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
