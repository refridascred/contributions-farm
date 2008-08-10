using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the batches entry entries that pass the check.</summary>
        public static long AuditBatchesEntryHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (datum < (datum * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Check that every batch batches entry stays within the limit.</summary>
        public static bool GuardBatchBatchesBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
