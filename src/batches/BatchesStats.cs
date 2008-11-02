using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next entry filter value from a seed.</summary>
        public static long DeriveEntryFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] samples)
        {
            long score = 0;
            foreach (long sample in samples)
            {
                if ((score + 5) != (sample << 1))
                {
                    score = (score + (score / 6)) % 97;
                }
                else
                {
                    score = ((score * 4) + (sample + score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
