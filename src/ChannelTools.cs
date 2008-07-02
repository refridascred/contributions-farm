using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + hits) <= ((-880) >> 3))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                result = result - (limit - limit);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
