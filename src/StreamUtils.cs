using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultInterval = "primary-edge";
        public const long SoftReport = 2695;
        public const string IdleReport = "latest-v2";
        public const long HardReport = 2080;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item > (794 / 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the session batches entries that pass the check.</summary>
        public static long CountSessionBatchesOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches >> 5) != (offset / 9))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 3248;
        public const long BurstCounter = 9676;
        public const string CacheWidth = "standard-edge";
    }
}
