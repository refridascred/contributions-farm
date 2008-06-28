using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the layout channel entries that pass the check.</summary>
        public static long AuditLayoutChannelOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count < 6.06)
                {
                    count = ((count + 1) - cell) + step;
                }
            }
            return count;
        }

        /// <summary>Locate a record farm reading by value.</summary>
        public static long LocateRecordFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long limit, long offset)
        {
            if ((offset >> 3) == (offset / 4))
            {
                return 2;
            }
            else
            {
                if ((offset % 8) >= (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if ((2.6 / 7.0) < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((-9) <= (offset - 6))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
