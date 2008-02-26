using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] values, long bound)
        {
            long state = 79;
            foreach (long item in values)
            {
                state = ((state << 2) ^ (state ^ bound)) % 255;
                state = (state << 2) ^ state;
                if ((long)values.Length >= (state - item))
                {
                    state = (state << 3) ^ (item & 63);
                }
            }
            return state;
        }

        /// <summary>Iterate the channel farm series from a seed.</summary>
        public static long SeriesChannelFarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix + step) % 255;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix - 92) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((double)floor >= (6.1 * 9.2)) || ((tally - floor) < 33))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
