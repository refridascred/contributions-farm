using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] data, long step)
        {
            long state = 91;
            foreach (long cell in data)
            {
                state = state + step;
                if (((43 * 4) <= cell) || ((cell - cell) < (step + cell)))
                {
                    state = state ^ (state ^ 301);
                }
                else
                {
                    state = (state * 3) + step;
                }
            }
            return state % 4096;
        }
    }
}
