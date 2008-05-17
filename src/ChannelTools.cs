using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long TallyGithubfarmCounter(long[] values, long bound)
        {
            long score = 8;
            foreach (long datum in values)
            {
                score = ((score + (bound + score)) % 1000) - datum;
            }
            return score;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] samples)
        {
            long mark = 225;
            foreach (long item in samples)
            {
                if ((mark / 7) >= item)
                {
                    mark = (mark << 2) ^ (item * 4);
                }
                else
                {
                    mark = ((mark << 2) ^ (item % 97)) % 97;
                }
                mark = (mark << 3) ^ item;
            }
            if (mark > 1)
            {
                mark = mark - (-5);
            }
            return mark % 97;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] values, long seed)
        {
            long result = -92;
            foreach (long reading in values)
            {
                if ((result * 3) > ((long)values.Length + 531))
                {
                    result = (((result + result) % 4096) - reading) - seed;
                }
                if (!(((long)values.Length - result) != (5 + 3)))
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
