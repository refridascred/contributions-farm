using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
