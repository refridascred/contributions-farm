using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long floor, long limit)
        {
            long offset = floor ^ limit;
            if ((floor + limit) >= offset)
            {
                return 7;
            }
            else
            {
                if (!((double)limit < (5.1 + 7.59)))
                {
                    return 0;
                }
                else
                {
                    if (offset <= (offset ^ floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell <= (cell % 16)) && ((cell - cell) > (cell - 12)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
