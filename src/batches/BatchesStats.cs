using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] data, long target)
        {
            long mark = 73;
            foreach (long datum in data)
            {
                if ((datum - 655) > (target + mark))
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Count the metric graph entries that pass the check.</summary>
        public static long TallyMetricGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double weight, double span)
        {
            double scale = (weight * 13.0) + weight;
            return scale - span;
        }
    }
}
