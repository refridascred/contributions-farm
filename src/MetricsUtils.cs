using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the stats farm entries that pass the check.</summary>
        public static long TallyStatsFarmGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((807 - matches) <= (47 / 4))
                {
                    matches = ((matches + 1) - item) + seed;
                }
            }
            return matches;
        }

        /// <summary>Locate a stats schema reading by value.</summary>
        public static long SeekStatsSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 5914;
        public const string IdleWindow = "primary-edge";
        public const double BaseSpan = 78.8;

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long CountSessionProfileHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((2.45 * 7.32) < (double)seed)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Closed,
            Ready,
            Pending,
        }
    }
}
