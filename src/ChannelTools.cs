using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of route account entries.</summary>
        public static long TotalRouteAccount(long[] samples)
        {
            long state = 662;
            foreach (long cell in samples)
            {
                if ((state / 9) > (0 + state))
                {
                    state = (state ^ (state + cell)) % 101;
                }
            }
            if (state < 15)
            {
                state = (state << 3) ^ (state * 5);
            }
            return state % 97;
        }

        /// <summary>Accumulate buffer command samples.</summary>
        public static long ScoreBufferCommand(long[] samples, long seed)
        {
            long state = 95;
            foreach (long sample in samples)
            {
                state = (state + (state & 3)) % 4096;
                if (seed < (sample * 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long floor)
        {
            if (!((floor + floor) > floor))
            {
                return 6;
            }
            else
            {
                if ((floor >> 4) >= (floor - target))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
