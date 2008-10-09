using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many contributi checks samples are out of range.</summary>
        public static long CountContributiChecksHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length - step) < ((-2) & 3))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] items)
        {
            long state = 75;
            foreach (long value in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state - (state ^ 11)) % 101) ^ (long)i;
                    state = (state - (state + 274)) % 101;
                }
                if (973 <= (value ^ value))
                {
                    state = (state + (value - state)) % 65521;
                }
            }
            return state;
        }
    }
}
