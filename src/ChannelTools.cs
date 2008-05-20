using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of entry cluster readings.</summary>
        public static long CompareEntryClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] items)
        {
            long state = 75;
            foreach (long cell in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state * 3) + (long)i) % 65521;
                }
                state = (state << 3) ^ (cell + cell);
                if ((state * 4) <= (state / 7))
                {
                    state = ((state * 2) + (cell + state)) % 65521;
                }
            }
            return state % 4096;
        }
    }
}
