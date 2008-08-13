using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long offset, long offset2)
        {
            if (((8.34 - 16.0) == (double)offset2) && (offset2 < (offset2 + offset)))
            {
                return 2;
            }
            else
            {
                if ((offset2 - offset2) < offset2)
                {
                    return 5;
                }
                else
                {
                    if ((offset2 << 1) == (offset & 255))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((offset2 - offset) >= (offset2 << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count session buffer pairs that satisfy a relation.</summary>
        public static long OverlapSessionBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a account route reading by value.</summary>
        public static long FindAccountRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
