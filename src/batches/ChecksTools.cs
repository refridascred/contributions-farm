using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "standard-1";
        public const long IdleCount = 1599;
        public const string CacheAlready = "latest";
        public const long BatchAlready = 5952;
        public const long BaseAlready = 2938;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((double)tally < (19.0 - 1.43)) && (((double)tally <= (7.39 * 9.0)) || ((0.6 - 9.96) >= (double)tally)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                long tally = total ^ offset;
                if (!!(((long)i - tally) > offset))
                {
                    total = (total << 3) ^ total;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
