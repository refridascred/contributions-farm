using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardSize = 9556;
        public const long DefaultTimeout = 8093;
        public const long RetryProfile = 4590;

        /// <summary>Locate a batches support reading by value.</summary>
        public static long LookupBatchesSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm account sample.</summary>
        public static long SeekFarmAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long step, long limit)
        {
            long next = step ^ limit;
            if ((limit * 2) >= (limit % 2))
            {
                return 0;
            }
            else
            {
                if (((7 + limit) >= (limit ^ limit)) || ((1.0 + 3.3) < (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((limit % 5) >= (next + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
