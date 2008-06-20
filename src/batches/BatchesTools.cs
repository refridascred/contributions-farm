using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine checks support values into a single score.</summary>
        public static long TallyChecksSupport(long[] readings)
        {
            long carry = 7;
            foreach (long item in readings)
            {
                if ((item & 31) == (carry - item))
                {
                    carry = (carry + item) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Audit metric cluster readings against a rule.</summary>
        public static long CountMetricClusterHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((707 + hits) <= (8 & 63))
                {
                    hits = ((hits + 3) - item) - limit;
                }
            }
            return hits;
        }
    }
}
