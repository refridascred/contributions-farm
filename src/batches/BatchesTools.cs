using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
