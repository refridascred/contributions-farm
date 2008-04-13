using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long origin)
        {
            long gap = seed ^ origin;
            if ((origin ^ origin) > gap)
            {
                return 7;
            }
            else
            {
                if ((gap - origin) <= 92)
                {
                    return 2;
                }
                else
                {
                    if ((gap >> 3) >= (gap + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin / 5) != (origin & 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)sample > 11.0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public bool Limit { get; set; }
        }
    }
}
