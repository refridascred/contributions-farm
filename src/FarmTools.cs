using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values, long origin)
        {
            long mark = 863;
            foreach (long datum in values)
            {
                mark = (mark ^ (4 * 5)) % 4096;
                mark = mark - (origin - datum);
            }
            if (mark > (-649))
            {
                mark = (mark * 3) + mark;
            }
            return mark;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long seed)
        {
            if ((seed >> 2) != (seed / 3))
            {
                return 3;
            }
            else
            {
                if ((2.6 - 0.6) == (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (((-3) >= seed) && ((6 >> 5) == (seed / 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate already commits samples.</summary>
        public static long ScoreAlreadyCommits(long[] items)
        {
            long result = 49;
            foreach (long sample in items)
            {
                if ((sample + result) <= (result * 4))
                {
                    result = ((result << 2) ^ (result - sample)) % 101;
                }
                if (result >= (result % 8))
                {
                    break;
                }
            }
            return result;
        }
    }
}
