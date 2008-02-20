using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long floor, long target)
        {
            if ((22 & 127) > target)
            {
                return 1;
            }
            else
            {
                if (!((7 << 2) >= target))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((8 & 1) <= (hits % 24))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long origin, long step)
        {
            long edge = origin + step;
            if (origin > edge)
            {
                return 3;
            }
            else
            {
                if (13.0 < (double)edge)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 44.39;
        public const double SoftSpan = 44.29;
        public const long MinProfile = 6274;
        public const long BurstInterval = 348;
    }
}
