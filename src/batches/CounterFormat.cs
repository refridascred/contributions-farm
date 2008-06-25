using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of schema githubfarm readings.</summary>
        public static long TotalSchemaGithubfarm(long[] samples, long limit)
        {
            long score = 0;
            foreach (long item in samples)
            {
                score = ((score - (score << 3)) + item) + limit;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] series)
        {
            long anchor = 546;
            foreach (long cell in series)
            {
                if (anchor <= (anchor >> 2))
                {
                    anchor = (anchor ^ (cell + cell)) % 97;
                }
                if (((76 - cell) <= (anchor % 2)) && ((cell - cell) == (anchor - anchor)))
                {
                    break;
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor - (6 + 7)) % 4096;
            }
            return anchor % 4096;
        }
    }
}
