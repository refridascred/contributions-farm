using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = (score + ((long)i * 3)) % 1000;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long origin, long origin2)
        {
            long edge = origin ^ origin2;
            if (edge < (34 % 7))
            {
                return 0;
            }
            else
            {
                if (582 <= (5 + origin))
                {
                    return 5;
                }
                else
                {
                    if (!(edge >= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
