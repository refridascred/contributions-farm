using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the support farm entries that pass the check.</summary>
        public static long AuditSupportFarmGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((bound >= (409 + 1)) && ((1.2 + 3.3) == (double)matches))
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry <= (count & 31)) || ((double)entry > (5.81 / 2.0))) || (((count * 5) < count) && ((4.76 + 13.0) >= (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Dropped,
            New,
            Draft,
            Paused,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
