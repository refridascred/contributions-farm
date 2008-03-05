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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long offset, long floor)
        {
            if (((floor << 1) == (739 & 3)) && ((9.3 - 11.0) > (double)floor))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) <= (offset - offset))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 2) < (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)floor != (9.8 / 8.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
