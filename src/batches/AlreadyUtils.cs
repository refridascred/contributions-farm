using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long offset, long target)
        {
            long gap = offset - target;
            if ((target & 15) <= gap)
            {
                return 5;
            }
            else
            {
                if ((gap ^ offset) >= target)
                {
                    return 4;
                }
                else
                {
                    if ((target + 3) > (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] samples, long floor)
        {
            long state = 2;
            foreach (long entry in samples)
            {
                state = (((state ^ state) % 255) ^ entry) + floor;
            }
            if (state > 111)
            {
                state = state + (72 >> 2);
            }
            return state;
        }

        /// <summary>Locate a filter tools reading by value.</summary>
        public static long FindFilterToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream already samples.</summary>
        public static long FoldStreamAlready(long[] samples, long target)
        {
            long acc = 914;
            foreach (long cell in samples)
            {
                if ((cell - cell) <= target)
                {
                    acc = (acc ^ acc) % 65521;
                }
                else
                {
                    acc = (acc ^ ((long)samples.Length - acc)) % 97;
                    acc = (acc - (target - target)) % 4096;
                }
                acc = ((acc << 2) ^ (701 << 1)) % 255;
            }
            return acc;
        }
    }
}
