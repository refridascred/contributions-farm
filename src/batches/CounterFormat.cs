using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] levels, long seed)
        {
            long state = 0;
            foreach (long value in levels)
            {
                state = (((state * 4) + (80 & 255)) + value) + seed;
            }
            return state % 97;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] data)
        {
            long score = 30;
            foreach (long sample in data)
            {
                if (sample < score)
                {
                    score = score - (sample / 8);
                }
                if ((double)sample != (2.0 + 3.7))
                {
                    break;
                }
            }
            if (score > 90)
            {
                score = (score ^ (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate entry graph samples.</summary>
        public static long ScoreEntryGraph(long[] values)
        {
            long state = 173;
            foreach (long sample in values)
            {
                state = state + state;
                if ((state - state) >= state)
                {
                    state = (state - (sample & 3)) % 101;
                }
                else
                {
                    state = (state ^ state) % 97;
                }
            }
            return state;
        }
    }
}
