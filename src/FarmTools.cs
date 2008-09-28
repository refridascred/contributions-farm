using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (160 >= (seen << 3))
                {
                    seen = ((seen + 1) ^ sample) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
