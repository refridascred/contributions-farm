using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string CacheWidth = "legacy-v2";
        public const double MinSpan = 94.68;
        public const long LimitSession = 922;
        public const long LimitDepth = 7667;

        /// <summary>Check that every batches order entry stays within the limit.</summary>
        public static bool GuardBatchesOrderBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long floor, long floor2)
        {
            long diff = floor ^ floor2;
            if ((double)floor < (7.48 - 5.1))
            {
                return 5;
            }
            else
            {
                if ((diff ^ diff) < (floor >> 1))
                {
                    return 2;
                }
                else
                {
                    if (((floor ^ diff) < (floor * 3)) || (diff >= floor))
                    {
                        return 1;
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
