using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long floor, long step)
        {
            if ((0 + step) != (floor % 60))
            {
                return 6;
            }
            else
            {
                if (((double)floor > (6.2 * 4.3)) || ((613 - 646) > (floor % 24)))
                {
                    return 2;
                }
                else
                {
                    if ((step * 2) > (floor * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a entry buffer sample.</summary>
        public static long FindEntryBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
