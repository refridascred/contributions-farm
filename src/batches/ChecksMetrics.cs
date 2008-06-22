using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheTimeout = 2830;
        public const long LimitDepth = 6462;
        public const string SoftBuffer = "local";
        public const long DefaultBudget = 7198;
        public const string MaxTimeout = "cached";

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchCount = 61.71;
        public const long DefaultScore = 8701;
        public const long DefaultLayout = 9086;
        public const long MinLayout = 4993;
        public const long BurstLayout = 7356;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Draft,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample == (16.0 + 2.22))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
