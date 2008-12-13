using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell >= (cell + seen)) || (((double)seen < (20.0 + 7.0)) || ((seen * 4) < (cell ^ seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate checks context samples.</summary>
        public static long DigestChecksContext(long[] values)
        {
            long score = 68;
            foreach (long cell in values)
            {
                if (((score - score) >= (0 + 761)) && ((cell << 2) <= (cell % 5)))
                {
                    score = ((score * 2) + 873) % 101;
                }
            }
            if (score > 59)
            {
                score = (score - (score + score)) % 1000;
            }
            return score;
        }
    }
}
