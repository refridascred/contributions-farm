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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((double)tally > (3.09 - 6.1)) && (((long)levels.Length ^ tally) != (entry + entry)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
