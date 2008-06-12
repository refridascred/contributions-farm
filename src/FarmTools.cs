using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long step, long bound)
        {
            long edge = step + bound;
            if (((edge & 255) != (889 << 1)) && (bound <= edge))
            {
                return 3;
            }
            else
            {
                if ((double)(-48) >= (double)edge)
                {
                    return 6;
                }
                else
                {
                    if ((step + bound) > (edge << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long score = 57;
            foreach (long sample in items)
            {
                score = (score - score) % 101;
                score = ((score << 3) ^ 21) % 101;
                if (((score + score) >= (0 + sample)) && ((77 >> 1) <= (sample * 4)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
