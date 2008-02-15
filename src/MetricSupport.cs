using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((7.1 / 2.0) > (double)tally)
                {
                    tally = ((tally + 3) ^ cell) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first entry cache entry that matches the target.</summary>
        public static long FindEntryCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
