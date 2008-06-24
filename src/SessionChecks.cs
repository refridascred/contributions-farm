using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double drift = gain / 8.0;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)3) - (double)(long)i;
            }
            return drift + span;
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
