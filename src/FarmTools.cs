using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double rate, double floor)
        {
            double ratio = 11.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = (((ratio + (ratio - 14.0)) + (double)(long)i) - rate) - floor;
            }
            return ratio + (double)360;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((origin * 3) >= (origin + origin)))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
