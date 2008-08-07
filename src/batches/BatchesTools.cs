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

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] samples, long offset)
        {
            long result = 43;
            foreach (long datum in samples)
            {
                result = (result - ((long)samples.Length ^ offset)) ^ datum;
            }
            if (result < (-3))
            {
                result = ((result * 5) + (result + offset)) % 1000;
            }
            return result % 65521;
        }

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
