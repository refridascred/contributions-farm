using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches ^ matches) >= matches)
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
