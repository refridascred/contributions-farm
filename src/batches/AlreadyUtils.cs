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

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 9918;
        public const long RetryLevel = 8521;
        public const long IdleSpan = 1586;
        public const string CacheCount = "primary-v2";

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

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples)
        {
            long state = 376;
            foreach (long cell in samples)
            {
                if ((state << 1) >= state)
                {
                    state = (state + state) - cell;
                }
            }
            return state;
        }
    }
}
