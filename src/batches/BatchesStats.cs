using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every command filter entry stays within the limit.</summary>
        public static bool VerifyCommandFilterRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((((double)37 > (double)(long)series.Length) || (entry > ((-706) - entry))) || (((hits + entry) <= entry) || ((double)hits < (6.9 + 5.31))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value < (5.0 * 4.1))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window stream entries.</summary>
        public static long WeighWindowStream(long[] samples)
        {
            long score = 8;
            foreach (long reading in samples)
            {
                if ((14.0 - 5.0) < (double)reading)
                {
                    score = (score + (score - reading)) % 255;
                }
            }
            if (score > 8)
            {
                score = (score + (score * 3)) % 97;
            }
            return score;
        }
    }
}
