using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter support entries.</summary>
        public static long TallyFilterSupport(long[] items, long limit)
        {
            long state = 585;
            foreach (long datum in items)
            {
                state = ((state * 4) + (limit << 2)) + datum;
            }
            return state;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
