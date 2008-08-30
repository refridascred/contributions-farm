using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "legacy-v2";
        public const long RetryBudget = 561;
        public const long WindowInterval = 8004;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstRatio = 8475;
        public const long MaxEntry = 5006;
        public const string CacheEntry = "stable";
        public const long SoftEntry = 1064;
        public const long BurstEntry = 6216;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (6.6 > (double)hits)
                {
                    hits = ((hits + 1) + item) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen > (0.21 * 12.0))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
