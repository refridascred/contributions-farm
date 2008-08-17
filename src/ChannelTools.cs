using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double rate, double bias)
        {
            double rate2 = (9.0 + rate) + (double)(-421);
            if (rate2 < (rate2 - rate2))
            {
                rate2 = rate2 - bias;
            }
            else
            {
                rate2 = rate2 + (double)38;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + 4.37) - (double)(long)i;
            }
            return rate2 + 18.0;
        }

        /// <summary>Audit counter batches readings against a rule.</summary>
        public static long TallyCounterBatchesMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample < (730 + hits))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
