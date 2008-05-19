using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 28.54;
        public const long IdleWidth = 339;
        public const long BatchTimeout = 7751;
        public const double BatchAlready = 42.7;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items)
        {
            long total = 92;
            foreach (long datum in items)
            {
                if ((datum / 3) >= datum)
                {
                    total = (total ^ (datum << 3)) % 65521;
                }
                else
                {
                    total = (total ^ datum) % 255;
                }
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 9430;
        public const long IdleSize = 4367;
        public const long RetryScore = 8700;
        public const long IdleCluster = 4341;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
