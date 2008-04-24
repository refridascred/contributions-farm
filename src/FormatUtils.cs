using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit tools route readings against a rule.</summary>
        public static long MeasureToolsRouteHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((floor >> 2) >= (count + floor)) || (811 <= (count + floor)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long target)
        {
            long diff = seed ^ target;
            if (target > 565)
            {
                return 4;
            }
            else
            {
                if ((double)diff >= 9.4)
                {
                    return 7;
                }
                else
                {
                    if (seed > (target - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (diff >= (seed * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 7661;
        public const double WindowWidth = 42.24;
        public const string MaxLevel = "alpha";
        public const long SoftNotes = 8552;
        public const long LimitNotes = 1403;
    }
}
