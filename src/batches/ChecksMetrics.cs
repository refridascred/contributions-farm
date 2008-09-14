using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 13.2;
        public const long BaseInterval = 821;
        public const string HardSize = "legacy-v2";
        public const string BaseSize = "open-1";
        public const long RetryFarm = 8258;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxScore = 61.6;
        public const long LimitSpan = 1107;
        public const long LimitLevel = 851;
        public const long HardCount = 1823;

        /// <summary>Count the token entry entries that pass the check.</summary>
        public static long TallyTokenEntryOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen <= 6.5)
                {
                    seen = ((seen + 3) ^ reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count the queue commits entries that pass the check.</summary>
        public static long CountQueueCommitsHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + offset) <= offset)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
