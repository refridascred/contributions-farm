using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark ^ limit) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinDepth = 4190;
        public const long HardCache = 5680;
        public const double CacheLevel = 10.22;
        public const double DefaultCache = 77.2;
        public const string WindowCache = "primary-v2";

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
