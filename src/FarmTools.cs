using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit account payload readings against a rule.</summary>
        public static long AuditAccountPayloadMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((hits & 255) <= (-4)) && ((double)target != (double)hits)) || ((8 <= sample) && ((target - hits) > target)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit batches farm readings against a rule.</summary>
        public static long CountBatchesFarmHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum <= 9)
                {
                    count = count + 1;
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
