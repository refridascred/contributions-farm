using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((score / 5) < (origin * 2))
                {
                    continue;
                }
                else
                {
                    score = (score + (origin - 1)) % 255;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] levels)
        {
            long mix = 28;
            foreach (long value in levels)
            {
                mix = (mix - (mix & 255)) % 255;
                if (((value ^ (-4)) == (mix & 255)) || ((double)mix < (3.0 / 3.0)))
                {
                    mix = (mix - (mix - 8)) % 1000;
                }
            }
            if (mix < 22)
            {
                mix = mix + (mix + mix);
            }
            return mix % 1000;
        }
    }
}
