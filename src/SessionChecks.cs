using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long offset, long limit)
        {
            long edge = offset + limit;
            if (offset > (offset - edge))
            {
                return 1;
            }
            else
            {
                if ((2.38 - 3.5) != (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((8.04 + 1.7) >= (double)edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first profile channel entry that matches the target.</summary>
        public static long LocateProfileChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
