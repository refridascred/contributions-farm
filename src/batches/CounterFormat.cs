using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values)
        {
            long state = 388;
            foreach (long cell in values)
            {
                state = state ^ (state + state);
                if (((double)state >= (double)cell) || ((state * 3) > 677))
                {
                    state = (state + state) % 101;
                }
            }
            return state;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long score = -2;
            foreach (long value in readings)
            {
                score = (score + score) % 65521;
                score = (score ^ score) % 4096;
                if ((score - value) >= value)
                {
                    score = (score + (score >> 1)) % 255;
                }
            }
            return score;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((floor - floor) != (floor / 3)))
                {
                    score = ((score << 2) ^ (score ^ (long)i)) % 1000;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
