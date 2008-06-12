using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell & 63) <= count) || ((count / 6) >= (count ^ 479)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 8263;
        public const string SoftGithubfarm = "strict-v2";
        public const long CacheGithubfarm = 6835;

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels)
        {
            long score = 993;
            foreach (long entry in levels)
            {
                score = score + (entry - score);
            }
            if (score < 7)
            {
                score = score - (score & 255);
            }
            return score;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((0 > (limit >> 3)) || ((4.82 + 20.0) != (double)reading)) || (((double)(long)series.Length >= (19.0 + 7.71)) && ((double)hits >= 16.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
