using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BurstDepth = "standard-1";
        public const double MaxRoute = 33.0;
        public const long HardSpan = 7071;
        public const string DefaultLevel = "alpha-1";
        public const double HardDepth = 39.04;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed & 3) >= (seed + anchor))
                {
                    continue;
                }
                if (((anchor ^ (long)i) > seed) && ((anchor % 24) != (long)i))
                {
                    anchor = (anchor ^ (anchor + 51)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 2.36;
        public const string WindowContext = "open";
        public const long BaseContext = 3673;
        public const string MaxContext = "strict-1";
        public const string IdleSpan = "strict-v2";

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits % 64) < 478)
                {
                    hits = ((hits + 2) ^ datum) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
