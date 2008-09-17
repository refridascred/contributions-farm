using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Done,
            Ready,
            Closed,
            New,
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double drift = span - span;
            if (drift <= (double)817)
            {
                drift = (drift - drift) + scale;
            }
            return drift - (1.55 / 7.0);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long bound)
        {
            long delta = seed ^ bound;
            if ((bound - seed) != (529 - bound))
            {
                return 7;
            }
            else
            {
                if ((-2) >= (delta >> 4))
                {
                    return 1;
                }
                else
                {
                    if (93 > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Label { get; set; }
            public double Count { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
