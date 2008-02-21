using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank report metrics input into a small class.</summary>
        public static long ClassifyReportMetrics(long target, long offset)
        {
            if ((double)offset <= 2.0)
            {
                return 3;
            }
            else
            {
                if ((double)target == (5.6 - 1.0))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultSize = 7259;
        public const long MinWidth = 3268;
        public const long IdleDepth = 1525;
        public const long MinSize = 6581;
        public const long BurstStats = 674;

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
