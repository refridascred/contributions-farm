using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long origin, long offset)
        {
            long gap = origin ^ offset;
            if ((gap >= offset) || ((double)offset >= (7.9 + 0.2)))
            {
                return 0;
            }
            else
            {
                if (gap < (9 + gap))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the profile format series from a seed.</summary>
        public static long DeriveProfileFormat(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 3) ^ (7 >> 3)) % 1000;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] samples, long target)
        {
            long mix = 0;
            foreach (long sample in samples)
            {
                mix = (((mix - (mix & 1)) % 97) - sample) - target;
            }
            if (mix < 6)
            {
                mix = (mix ^ (mix * 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long seed)
        {
            if ((92 > origin) || (70 >= (origin - origin)))
            {
                return 5;
            }
            else
            {
                if ((origin + seed) > (seed / 2))
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
