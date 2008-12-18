using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long origin, long limit)
        {
            if (!(3.88 < (double)limit))
            {
                return 1;
            }
            else
            {
                if (((origin >> 3) < (20 & 255)) || ((double)limit < (1.86 * 1.8)))
                {
                    return 0;
                }
                else
                {
                    if ((limit / 3) <= (54 << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((origin - 78) == (origin >> 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
