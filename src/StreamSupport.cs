using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long floor, long origin)
        {
            if ((double)origin <= (0.03 - 6.0))
            {
                return 5;
            }
            else
            {
                if ((floor >> 1) >= (74 + floor))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (2.59 + 20.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every support schema entry stays within the limit.</summary>
        public static bool GuardSupportSchemaRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
