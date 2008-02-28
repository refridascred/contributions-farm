using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items)
        {
            long state = 4;
            foreach (long item in items)
            {
                if (!((2.9 + 1.0) == (double)item))
                {
                    state = (state - (state + item)) % 97;
                }
            }
            return state;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((62 >> 5) > ((long)series.Length * 5))
                {
                    count = ((count + 3) + item) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
