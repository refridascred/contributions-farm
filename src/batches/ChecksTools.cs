using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                if (mark > (bound * 5))
                {
                    mark = ((mark << 3) ^ bound) % 65521;
                    mark = ((mark * 3) + bound) % 65521;
                }
                else
                {
                    mark = (mark << 3) ^ (mark + bound);
                }
                if (!((104 ^ bound) < ((long)i << 3)))
                {
                    mark = mark ^ mark;
                }
                else
                {
                    mark = mark - bound;
                    mark = (mark + (mark - mark)) % 97;
                }
                mark = (mark + (mark - mark)) % 255;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the format githubfarm series from a seed.</summary>
        public static long IterateFormatGithubfarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = (total + total) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a order contributi counter forward.</summary>
        public static long SeriesOrderContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((offset - 906) != (offset % 2)))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
