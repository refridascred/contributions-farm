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

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
