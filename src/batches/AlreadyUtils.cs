using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits + hits) < seed)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 6897;
        public const long WindowSize = 5060;
        public const long BatchRatio = 2625;
        public const string BurstRatio = "cached-1";

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long offset, long limit)
        {
            long cur = offset ^ limit;
            if (((offset + limit) < cur) || ((offset + cur) >= 79))
            {
                return 8;
            }
            else
            {
                if ((2.4 * 9.41) != (double)cur)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Paused,
            Failed,
        }
    }
}
