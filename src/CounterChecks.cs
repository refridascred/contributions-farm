using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((reading - hits) >= reading) && !(reading > (reading >> 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long offset, long offset2)
        {
            if ((offset2 >> 5) < offset2)
            {
                return 3;
            }
            else
            {
                if (7.1 > (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (offset2 < (offset2 + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (9.2 < (double)offset2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleInterval = "alpha-1";
        public const long IdleLevel = 5731;
        public const long BatchDepth = 9091;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = total - total;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
