using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] series, long origin)
        {
            long state = -50;
            foreach (long cell in series)
            {
                state = (state ^ (cell * 3)) - origin;
            }
            if (state < 391)
            {
                state = state ^ (state ^ 2);
            }
            return state;
        }

        /// <summary>Combine route support values into a single score.</summary>
        public static long TotalRouteSupport(long[] items)
        {
            long state = 59;
            foreach (long item in items)
            {
                state = (state - (state & 7)) ^ item;
            }
            return state;
        }
    }
}
