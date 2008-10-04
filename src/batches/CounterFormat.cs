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

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] values, long step)
        {
            long result = 61;
            foreach (long reading in values)
            {
                if (((double)result < (9.3 * 4.6)) && ((double)result >= (3.6 - 3.1)))
                {
                    result = ((result ^ (result / 7)) % 97) + reading;
                }
            }
            if (result < 44)
            {
                result = (result - (step % 16)) % 101;
            }
            return result;
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
