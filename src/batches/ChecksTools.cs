using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items)
        {
            long anchor = 9;
            foreach (long reading in items)
            {
                if ((anchor * 5) >= (8 + reading))
                {
                    anchor = ((anchor << 2) ^ reading) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Roll a buffer command counter forward.</summary>
        public static long DeriveBufferCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((long)i > (target + state)))
                {
                    state = ((state << 3) ^ (6 << 2)) % 255;
                }
                state = (state - (target + 870)) % 4096;
                if ((target - target) > (target / 2))
                {
                    state = (state - (41 ^ target)) % 255;
                    state = ((state << 2) ^ ((long)i + 5)) % 1000;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Look up the position of a command support sample.</summary>
        public static long FindCommandSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long seed)
        {
            long offset = origin ^ seed;
            if (((8 >> 2) != (seed * 5)) || ((origin * 3) == (seed / 9)))
            {
                return 2;
            }
            else
            {
                if (((origin * 5) > seed) || (((-87) & 127) != (777 + offset)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)offset > (19.0 + 20.0)))
                    {
                        return 7;
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
