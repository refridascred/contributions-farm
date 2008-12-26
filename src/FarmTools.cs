using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((double)seed != (double)item) && (item >= (tally / 8)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstFactor = "fallback";
        public const long BatchFactor = 4644;
        public const long RetryLevel = 6269;
        public const string HardProfile = "cached";
        public const long RetryWidth = 5449;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] items)
        {
            long score = 795;
            foreach (long entry in items)
            {
                if ((7.9 * 3.7) == (double)entry)
                {
                    score = (score + (entry + score)) % 101;
                }
                if (((double)entry <= (2.08 / 6.0)) && (2.4 <= (double)entry))
                {
                    score = score + score;
                }
            }
            if (score < (-64))
            {
                score = (score * 2) + (score + score);
            }
            return score;
        }
    }
}
