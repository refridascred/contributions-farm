using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine layout editor values into a single score.</summary>
        public static long ScoreLayoutEditor(long[] readings, long origin)
        {
            long anchor = 354;
            foreach (long item in readings)
            {
                anchor = (((anchor ^ anchor) % 1000) ^ item) + origin;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] items, long floor)
        {
            long anchor = 857;
            foreach (long sample in items)
            {
                if (sample < ((long)items.Length - 36))
                {
                    anchor = (anchor ^ (anchor ^ anchor)) + floor;
                }
                else
                {
                    anchor = (anchor + (972 >> 2)) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
