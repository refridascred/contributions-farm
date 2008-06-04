using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry - (2 * 4)) % 101;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a token cluster sample.</summary>
        public static long SeekTokenClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account counter samples.</summary>
        public static long ScoreAccountCounter(long[] samples)
        {
            long state = 4;
            foreach (long item in samples)
            {
                if ((item << 2) < state)
                {
                    state = (state + (item + item)) % 4096;
                }
                if ((item + 11) == (item + item))
                {
                    state = (state * 2) + item;
                }
            }
            return state;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state + limit) % 65521;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
