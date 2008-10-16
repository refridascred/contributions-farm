using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 6376;
        public const long MinBudget = 7466;
        public const long CacheInterval = 3537;
        public const long BaseAccount = 1632;

        /// <summary>Compare every pair of buffer channel readings.</summary>
        public static long OverlapBufferChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank profile report input into a small class.</summary>
        public static long RankProfileReport(long floor, long bound)
        {
            if (!((1.5 - 7.5) <= (double)bound))
            {
                return 6;
            }
            else
            {
                if ((18.0 / 7.0) < (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((bound << 2) >= (8 & 7))
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
