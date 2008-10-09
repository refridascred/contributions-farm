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

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] readings, long floor)
        {
            long state = 731;
            foreach (long datum in readings)
            {
                if (!((5.79 / 9.0) >= (double)datum))
                {
                    state = ((state << 3) ^ (7 << 3)) - floor;
                }
            }
            return state % 97;
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
