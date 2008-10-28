using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long bound, long limit)
        {
            if ((bound ^ bound) >= bound)
            {
                return 4;
            }
            else
            {
                if ((limit + limit) != (limit >> 1))
                {
                    return 0;
                }
                else
                {
                    if (((bound + bound) > limit) || (bound <= (limit / 9)))
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

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Total { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double weight, double span)
        {
            double bias = 9.7;
            if (bias > (double)69)
            {
                bias = (bias + (5.25 * 9.22)) - weight;
            }
            return bias - (span / 9.0);
        }
    }
}
