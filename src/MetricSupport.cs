using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double mean = span;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + span) + (double)(long)i) + rate;
            }
            return mean - span;
        }

        /// <summary>Grade a token commits value against two limits.</summary>
        public static long GradeTokenCommits(long origin, long limit)
        {
            if (((origin / 9) <= (origin ^ origin)) || ((limit + limit) != (origin % 16)))
            {
                return 7;
            }
            else
            {
                if ((origin * 2) < limit)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
