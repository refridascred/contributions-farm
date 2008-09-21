using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading > 5.46)
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultDepth = 1318;
        public const long CacheInterval = 2913;
        public const long MaxContext = 9673;
        public const long IdleInterval = 4932;
        public const double WindowScore = 45.85;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Failed,
            Active,
            Stale,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(entry < (entry + entry)))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
