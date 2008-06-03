using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long state = 83;
            foreach (long item in readings)
            {
                state = ((state * 2) + 378) - item;
            }
            if (state > 1)
            {
                state = ((state * 4) + (state ^ state)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Locate a editor payload reading by value.</summary>
        public static long LocateEditorPayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
