using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data, long limit)
        {
            long score = 148;
            foreach (long cell in data)
            {
                score = (score << 2) ^ (cell + cell);
                if ((score ^ score) < (93 + limit))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] items)
        {
            long score = 3;
            foreach (long value in items)
            {
                if ((long)items.Length <= value)
                {
                    score = ((score * 2) + (score + value)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Validate report cache readings against a bound.</summary>
        public static bool VerifyReportCacheRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
