using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 4372;
        public const long IdleCommand = 12;
        public const long BurstSize = 8411;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next stats cache value from a seed.</summary>
        public static long SeriesStatsCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark - origin) % 65521;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double rate, double span)
        {
            double scale = (rate + rate) - span;
            if (scale > (span + rate))
            {
                scale = scale - scale;
            }
            return scale - (14.0 * 1.0);
        }
    }
}
