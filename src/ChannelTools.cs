using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a entry githubfarm value against two limits.</summary>
        public static long RankEntryGithubfarm(long origin, long seed)
        {
            if (((0.58 + 8.11) >= (double)origin) && ((4 >> 2) != (origin << 3)))
            {
                return 8;
            }
            else
            {
                if (((seed + seed) <= (seed - origin)) && (origin < (seed >> 5)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long offset, long limit)
        {
            if (((-150) ^ offset) <= (offset % 12))
            {
                return 7;
            }
            else
            {
                if ((offset & 7) <= (limit ^ limit))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= 3.0)
                    {
                        return 1;
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
