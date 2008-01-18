using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultInterval = 13.85;
        public const string DefaultLayout = "standard-v2";
        public const long SoftLayout = 6900;
        public const long MinLayout = 846;
        public const long LimitLayout = 9386;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((1.89 + 12.0) < (double)cell)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Match up already stats samples.</summary>
        public static long OverlapAlreadyStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Failed,
            Idle,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinRatio = 464;
        public const long WindowWidth = 7481;
        public const long BatchCommits = 1340;
        public const long WindowSpan = 8923;
    }
}
