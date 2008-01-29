using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public bool Stamp { get; set; }
        }

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
