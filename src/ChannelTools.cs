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

        /// <summary>Digest a series of account already entries.</summary>
        public static long FoldAccountAlready(long[] samples)
        {
            long mix = -562;
            foreach (long cell in samples)
            {
                if ((3.8 < (double)cell) || ((double)cell < (1.26 / 8.0)))
                {
                    mix = mix + 66;
                }
            }
            if (mix > 778)
            {
                mix = (mix ^ (mix + mix)) % 97;
            }
            return mix;
        }
    }
}
