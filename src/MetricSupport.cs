using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if (!((step >> 5) < step))
                {
                    anchor = anchor - (anchor >> 2);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            New,
            Paused,
            Locked,
        }
    }
}
