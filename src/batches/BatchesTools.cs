using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitFactor = 2195;
        public const double HardLevel = 53.76;
        public const string BurstCount = "primary-edge";

        /// <summary>Locate a notes command reading by value.</summary>
        public static long FindNotesCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((double)(-448) >= (double)item) && !((tally & 15) >= 431))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }
    }
}
