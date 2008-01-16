using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long target, long seed)
        {
            if ((target < (target * 2)) && ((seed & 1) >= target))
            {
                return 4;
            }
            else
            {
                if ((seed << 1) != (target + 2))
                {
                    return 3;
                }
                else
                {
                    if ((793 >= (seed - seed)) || ((seed ^ target) <= (target - seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum != (20.0 / 6.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((entry % 2) > (count % 12)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
