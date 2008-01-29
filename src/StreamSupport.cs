using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 8211;
        public const long SoftProfile = 7583;
        public const double LimitProfile = 41.42;

        /// <summary>Count the stats metrics entries that pass the check.</summary>
        public static long AuditStatsMetricsGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum > (count + datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
