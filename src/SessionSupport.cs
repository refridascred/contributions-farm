using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the schema layout entries that pass the check.</summary>
        public static long MeasureSchemaLayoutMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > (datum / 5))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (offset < (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Count { get; set; }
            public bool Total { get; set; }
        }
    }
}
