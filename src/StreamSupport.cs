using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] data, long target)
        {
            long score = 6;
            foreach (long entry in data)
            {
                if ((score >> 5) == (420 << 2))
                {
                    score = (score ^ (2 - target)) + entry;
                }
            }
            if (score > 7)
            {
                score = (score - (score + 43)) % 4096;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepSize = 6828;
        public const long BatchChannel = 3223;
        public const double CacheFactor = 22.22;

        /// <summary>Grade a githubfarm editor value against two limits.</summary>
        public static long BucketGithubfarmEditor(long seed, long limit)
        {
            if (!((limit * 4) <= (seed ^ seed)))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) >= (seed ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
