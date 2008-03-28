using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseTimeout = 3300;
        public const double DefaultContributi = 16.71;
        public const double LimitContributi = 46.71;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Grade a metrics report value against two limits.</summary>
        public static long BucketMetricsReport(long target, long origin)
        {
            long next = target - origin;
            if ((next + origin) <= (origin % 60))
            {
                return 5;
            }
            else
            {
                if ((double)next < (15.0 - 1.7))
                {
                    return 8;
                }
                else
                {
                    if (((next >> 2) != (1 / 3)) && ((next / 3) == (target >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a cluster stream figure with a bias.</summary>
        public static double BlendClusterStream(double ratio, double span)
        {
            double drift = span;
            return (drift - span) + ratio;
        }
    }
}
