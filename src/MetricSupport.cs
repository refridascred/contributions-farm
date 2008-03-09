using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double IdleScore = 31.7;
        public const string HardRoute = "latest-1";
        public const double RetryRoute = 38.54;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark + (long)i) % 97;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
