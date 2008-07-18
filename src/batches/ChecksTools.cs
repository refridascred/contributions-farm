using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up githubfarm counter samples.</summary>
        public static long MatchGithubfarmCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheScore = 37.31;
        public const long BaseTimeout = 2294;
        public const double WindowDepth = 36.38;
        public const long MaxReport = 2536;

        /// <summary>Fold a list of context layout readings.</summary>
        public static long ScoreContextLayout(long[] samples, long bound)
        {
            long mark = 55;
            foreach (long datum in samples)
            {
                mark = ((mark ^ (mark - datum)) % 4096) - bound;
            }
            return mark % 1000;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long offset2)
        {
            if (((offset ^ offset2) <= (382 % 8)) || ((6.9 * 3.2) >= (double)offset2))
            {
                return 7;
            }
            else
            {
                if (592 < offset2)
                {
                    return 5;
                }
                else
                {
                    if (!((9.0 * 6.4) >= (double)offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
