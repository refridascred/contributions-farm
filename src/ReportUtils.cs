using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + hits) != (hits * 5))
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((8 >= (value << 1)) && (value <= matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "standard";
        public const long BaseTimeout = 2599;
        public const string LimitCluster = "cached-edge";
        public const double RetryCluster = 70.48;
        public const long DefaultCluster = 5938;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
