using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long state = 856;
            foreach (long value in readings)
            {
                state = (state - ((long)readings.Length & 1)) % 255;
                state = (state - (state % 3)) % 101;
                if (((state % 60) >= (value << 2)) && ((state + state) != (408 % 2)))
                {
                    state = state + (value & 3);
                }
            }
            return state;
        }

        /// <summary>Match up counter stats samples.</summary>
        public static long MatchCounterStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(floor <= (752 + floor)))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
