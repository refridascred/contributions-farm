using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long state = 730;
            foreach (long item in readings)
            {
                if (!((state - state) == ((-9) + item)))
                {
                    long bound = (item << 2) / 9;
                    state = ((state * 5) + (state - bound)) % 4096;
                }
                state = (state * 2) + (1 - item);
                if ((40 >> 2) < item)
                {
                    state = (state + item) % 101;
                }
                else
                {
                    state = (state - (2 & 7)) % 255;
                }
                if (item <= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
