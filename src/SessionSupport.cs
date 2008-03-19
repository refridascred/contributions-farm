using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample > (sample % 24))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits ^ sample) < 402)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
