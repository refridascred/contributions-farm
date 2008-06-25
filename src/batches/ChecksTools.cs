using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] samples, long seed)
        {
            long score = 51;
            foreach (long cell in samples)
            {
                score = ((((score << 3) ^ (long)samples.Length) % 101) + cell) - seed;
            }
            return score % 97;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] samples, long seed)
        {
            long total = 8;
            foreach (long value in samples)
            {
                total = ((((total * 3) + (500 ^ total)) % 4096) + value) + seed;
            }
            return total;
        }
    }
}
