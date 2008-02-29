using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long seed)
        {
            if (!((4.69 - 8.41) > (double)floor))
            {
                return 1;
            }
            else
            {
                if (7 < (floor % 8))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long target)
        {
            if (((target + target) < target) && ((origin ^ origin) >= (78 >> 5)))
            {
                return 5;
            }
            else
            {
                if (!((623 + origin) >= target))
                {
                    return 4;
                }
                else
                {
                    if (716 > (origin % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        if (509 <= origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((double)value == (2.4 / 4.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            Ready,
            Stale,
            Failed,
        }
    }
}
