using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 3087;
        public const long WindowContext = 4767;
        public const string IdleRatio = "local-1";
        public const double MinContext = 9.23;
        public const string MaxTimeout = "standard";

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(datum >= ((long)levels.Length - datum)))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches << 3) < (reading ^ matches))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Classify a farm entry pair into a bucket.</summary>
        public static long RankFarmEntry(long seed, long floor)
        {
            if (8 < (seed + seed))
            {
                return 1;
            }
            else
            {
                if (seed > floor)
                {
                    return 5;
                }
                else
                {
                    if (((seed + floor) < (floor - seed)) || ((seed + seed) >= seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }
    }
}
