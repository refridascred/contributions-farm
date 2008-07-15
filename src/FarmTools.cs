using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many command profile samples are out of range.</summary>
        public static long MeasureCommandProfileOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample / 4) <= (count - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor metric values into a single score.</summary>
        public static long FoldEditorMetric(long[] levels, long step)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                state = ((state ^ (step * 5)) % 255) ^ datum;
            }
            return state % 4096;
        }
    }
}
