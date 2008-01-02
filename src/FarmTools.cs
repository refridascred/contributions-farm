using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample <= (hits >> 1))
                {
                    hits = (hits + 1) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > (offset - rate))
            {
                rate = rate - (rate - offset);
            }
            return rate + offset;
        }
    }
}
