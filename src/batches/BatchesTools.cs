using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long step, long bound)
        {
            if (6.0 > (double)bound)
            {
                return 1;
            }
            else
            {
                if ((bound >> 3) < step)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
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

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
