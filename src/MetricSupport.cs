using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
