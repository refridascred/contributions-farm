using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell >= (hits / 5))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Audit profile stream readings against a rule.</summary>
        public static long CountProfileStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading << 3) >= 86)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
