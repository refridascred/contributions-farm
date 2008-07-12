using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "legacy-v2";
        public const long HardCount = 6541;
        public const long MinFactor = 9884;
        public const long SoftScore = 5816;
        public const long RetryScore = 2353;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((6 & 15) >= (reading >> 5))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowSize = 8011;
        public const long CacheCounter = 9655;
        public const long MaxSize = 3209;
    }
}
