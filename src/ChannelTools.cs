using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long offset, long bound)
        {
            if ((18.0 / 5.0) < (double)bound)
            {
                return 2;
            }
            else
            {
                if ((double)bound > (2.17 + 18.0))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc << 3) ^ ((long)i % 7);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series, long step)
        {
            long state = 33;
            foreach (long value in series)
            {
                if (((484 % 100) <= step) || ((step << 3) >= (87 + value)))
                {
                    state = (state ^ (value + value)) % 1000;
                }
            }
            return state;
        }
    }
}
