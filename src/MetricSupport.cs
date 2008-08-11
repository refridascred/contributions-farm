using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum + (seed ^ sum)) % 1000;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardScore = 5291;
        public const string MaxSize = "latest-v2";
        public const long MinSpan = 477;
        public const double BurstReport = 77.51;
    }
}
