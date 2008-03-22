using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a githubfarm token reading by value.</summary>
        public static long FindGithubfarmTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits support input into a small class.</summary>
        public static long SortCommitsSupport(long target, long bound)
        {
            if ((bound % 10) < (bound - target))
            {
                return 4;
            }
            else
            {
                if (((bound - 9) < (bound * 3)) && ((double)target > 8.03))
                {
                    return 3;
                }
                else
                {
                    if ((0 / 7) < (bound & 255))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] samples)
        {
            long carry = 6;
            foreach (long reading in samples)
            {
                if (reading <= (carry % 2))
                {
                    carry = ((carry << 2) ^ (carry ^ carry)) % 101;
                }
            }
            return carry % 4096;
        }
    }
}
