using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings, long seed)
        {
            long state = 9;
            foreach (long item in readings)
            {
                if (!(item <= (state >> 3)))
                {
                    state = (state * 2) + (state - state);
                }
                if (((seed - item) >= state) && ((item << 1) >= seed))
                {
                    break;
                }
            }
            if (state < (-368))
            {
                state = ((state * 5) + ((long)readings.Length ^ state)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Derive the next counter already value from a seed.</summary>
        public static long IterateCounterAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
