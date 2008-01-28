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

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long sum = -83;
            foreach (long value in series)
            {
                if (!((sum - sum) < (570 >> 2)))
                {
                    sum = ((sum << 3) ^ (65 + sum)) + value;
                }
                else
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
            }
            if (sum < 33)
            {
                sum = ((sum << 3) ^ (sum >> 5)) % 1000;
            }
            return sum;
        }
    }
}
