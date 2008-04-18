using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long bound, long target)
        {
            long offset = bound + target;
            if ((offset - offset) == (target >> 5))
            {
                return 7;
            }
            else
            {
                if ((target >= bound) || ((offset / 2) == (bound & 3)))
                {
                    return 0;
                }
                else
                {
                    if ((double)target == (11.0 - 2.4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 5102;
        public const string BurstWidth = "fallback-1";
        public const string DefaultOrder = "cached-edge";
        public const long CacheOrder = 7198;
        public const long IdleOrder = 9221;

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
