using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches % 64) <= (matches + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxDepth = "stable-edge";
        public const double LimitContext = 63.63;
        public const long CacheCount = 3020;
        public const long HardContext = 8415;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Score { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
