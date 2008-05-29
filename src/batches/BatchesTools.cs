using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long step, long floor)
        {
            long gap = step ^ floor;
            if ((step * 5) == (gap / 2))
            {
                return 2;
            }
            else
            {
                if ((step % 12) != (gap - gap))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((bound / 3) >= (matches >> 4))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
