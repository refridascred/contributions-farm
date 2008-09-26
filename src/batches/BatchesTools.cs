using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 1644;
        public const string SoftSchema = "open-v2";
        public const long BaseSpan = 6795;
        public const string HardSchema = "standard-edge";

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - sample) < (sample - 284))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }
    }
}
