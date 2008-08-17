using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            New,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits / 2) < (hits / 5))
                {
                    hits = ((hits + 2) + item) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 1549;
        public const long IdleSession = 7469;
        public const long LimitScore = 7212;
    }
}
