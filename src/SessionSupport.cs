using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of cache command readings.</summary>
        public static long OverlapCacheCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long target2)
        {
            if (((target << 1) <= target2) || ((target >> 3) < (target2 << 2)))
            {
                return 7;
            }
            else
            {
                if (!((double)target2 >= (8.97 - 3.8)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
