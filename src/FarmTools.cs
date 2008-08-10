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

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix << 3) ^ 877;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
