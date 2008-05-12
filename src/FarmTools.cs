using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((origin & 3) == (matches % 2))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a graph token sample.</summary>
        public static long FindGraphTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
