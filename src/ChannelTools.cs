using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate already counter samples.</summary>
        public static long WeighAlreadyCounter(long[] levels)
        {
            long sum = 796;
            foreach (long value in levels)
            {
                if ((double)sum > (2.4 / 4.0))
                {
                    sum = ((sum << 3) ^ (value / 7)) % 1000;
                }
            }
            if (sum < 815)
            {
                sum = sum - (sum & 1);
            }
            return sum % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (2.0 - 6.9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] levels, long seed)
        {
            long state = 6;
            foreach (long entry in levels)
            {
                state = ((state - (entry >> 5)) % 101) - seed;
                if (((double)entry >= 20.0) && (entry > ((-9) / 3)))
                {
                    state = ((state * 3) + (entry + 996)) % 255;
                }
                if ((state & 7) <= 831)
                {
                    state = (state - (entry - state)) % 1000;
                }
            }
            return state;
        }
    }
}
