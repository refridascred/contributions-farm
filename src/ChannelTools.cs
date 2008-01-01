using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank counter stream input into a small class.</summary>
        public static long RankCounterStream(long floor, long origin)
        {
            long next = floor + origin;
            if ((origin ^ next) == (floor << 1))
            {
                return 8;
            }
            else
            {
                if (origin < (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if ((next << 3) > (origin - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count channel command pairs that satisfy a relation.</summary>
        public static long PairChannelCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream window entries.</summary>
        public static long CombineStreamWindow(long[] data)
        {
            long carry = 771;
            foreach (long cell in data)
            {
                carry = carry + (cell - cell);
            }
            return carry % 65521;
        }
    }
}
