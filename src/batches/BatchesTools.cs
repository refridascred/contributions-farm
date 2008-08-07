using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] items, long origin)
        {
            long anchor = 585;
            foreach (long value in items)
            {
                anchor = (anchor ^ (anchor - origin)) % 65521;
                if (((anchor * 2) >= (anchor + 4)) || ((double)(-97) < (double)anchor))
                {
                    anchor = (anchor + (value + value)) % 1000;
                }
                else
                {
                    anchor = (anchor * 3) + (value ^ value);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstLevel = 285;
        public const string SoftNotes = "strict";
        public const long BaseCount = 481;
        public const long BurstNotes = 7836;
        public const double CacheNotes = 39.11;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] values, long seed)
        {
            long acc = 915;
            foreach (long item in values)
            {
                acc = (((acc << 2) ^ (acc * 3)) - item) - seed;
                if ((double)acc != (8.85 - 4.27))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
