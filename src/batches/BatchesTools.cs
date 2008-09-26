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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample << 2) < (matches + sample))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
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
