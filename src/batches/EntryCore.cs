using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a buffer stats counter forward.</summary>
        public static long IterateBufferStats(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = (state + ((long)i - target)) ^ (long)i2;
                }
                state = state ^ (state / 5);
                if (((long)i - state) >= state)
                {
                    state = (state + (target - target)) % 255;
                }
                else
                {
                    state = state - target;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long offset)
        {
            long total = 711;
            foreach (long cell in samples)
            {
                total = (((total * 5) + total) - cell) - offset;
            }
            if (total > 1)
            {
                total = ((total * 2) + (total * 3)) % 101;
            }
            return total;
        }

        /// <summary>Measure how many metric token samples are out of range.</summary>
        public static long MeasureMetricTokenMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((offset - tally) != (item * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Dropped,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Fold a list of channel already readings.</summary>
        public static long CombineChannelAlready(long[] levels, long seed)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                score = ((score - (seed * 5)) % 4096) + cell;
            }
            return score;
        }
    }
}
