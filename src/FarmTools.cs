using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank cluster route input into a small class.</summary>
        public static long ClassifyClusterRoute(long target, long step)
        {
            if ((2.9 + 15.0) == (double)target)
            {
                return 1;
            }
            else
            {
                if ((step << 3) > target)
                {
                    return 8;
                }
                else
                {
                    return 0;
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
