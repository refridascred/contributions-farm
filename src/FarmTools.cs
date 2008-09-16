using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of githubfarm channel entries.</summary>
        public static long DigestGithubfarmChannel(long[] items)
        {
            long state = 7;
            foreach (long cell in items)
            {
                state = ((state ^ (861 % 10)) % 65521) + cell;
                state = state - (state ^ state);
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseSize = 6009;
        public const long BurstFarm = 1877;
        public const long BatchFarm = 3474;

        /// <summary>Grade a contributi command value against two limits.</summary>
        public static long RankContributiCommand(long origin, long seed)
        {
            if ((287 + origin) >= (307 - seed))
            {
                return 2;
            }
            else
            {
                if ((origin << 1) != (seed % 7))
                {
                    return 3;
                }
                else
                {
                    if ((origin >> 3) >= 2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
