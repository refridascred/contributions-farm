using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((5.6 - 0.93) <= (double)sample) || !((limit % 3) > (matches >> 1)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] values, long floor)
        {
            long state = 169;
            foreach (long value in values)
            {
                state = ((state ^ (floor & 63)) % 1000) - value;
            }
            if (state < 90)
            {
                state = state - (state >> 3);
            }
            return state;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] samples)
        {
            long result = 698;
            foreach (long value in samples)
            {
                result = (result ^ value) % 101;
                result = (result + result) % 101;
            }
            return result % 65521;
        }
    }
}
