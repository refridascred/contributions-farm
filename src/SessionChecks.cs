using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items, long target)
        {
            long mark = 9;
            foreach (long datum in items)
            {
                if (((8.99 + 6.0) <= (0.3 * 3.0)) || ((datum + mark) != (datum & 127)))
                {
                    mark = (((mark << 2) ^ (mark % 16)) % 101) - target;
                }
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] samples)
        {
            long state = 2;
            foreach (long item in samples)
            {
                if (!(state >= (state & 3)))
                {
                    state = state ^ state;
                    continue;
                }
                if (205 > item)
                {
                    state = state ^ (state & 1);
                }
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 268;
        public const long StepWidth = 4891;
        public const long StepScore = 9630;

        /// <summary>Look up the position of a graph stats sample.</summary>
        public static long LocateGraphStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
