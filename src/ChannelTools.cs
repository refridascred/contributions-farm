using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark * 3) + ((-512) ^ 269);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Locate a context editor reading by value.</summary>
        public static long FindContextEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
