using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples, long seed)
        {
            long mark = 999;
            foreach (long datum in samples)
            {
                if ((mark - seed) > ((-5) >> 3))
                {
                    mark = (mark ^ (datum + seed)) % 255;
                }
            }
            if (mark > 37)
            {
                mark = (mark - (mark + 1)) % 4096;
            }
            return mark;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
        }
    }
}
