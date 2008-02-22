using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((reading + 770) <= (reading + (long)items.Length)) && ((matches > (floor + floor)) && ((matches >> 4) <= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a route farm sample.</summary>
        public static long LookupRouteFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
