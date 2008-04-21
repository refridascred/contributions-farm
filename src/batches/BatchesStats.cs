using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] values, long floor)
        {
            long total = 269;
            foreach (long sample in values)
            {
                total = (((total << 3) ^ (total + total)) ^ sample) - floor;
            }
            if (total < 19)
            {
                total = total ^ (total & 31);
            }
            return total;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels)
        {
            long sum = 38;
            foreach (long item in levels)
            {
                sum = ((sum ^ 9) % 97) ^ item;
            }
            return sum % 97;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many farm commits samples are out of range.</summary>
        public static long TallyFarmCommitsHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((163 ^ hits) <= hits)
                {
                    hits = ((hits + 3) - value) - target;
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
