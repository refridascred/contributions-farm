using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseWidth = 8655;
        public const long IdleInterval = 541;
        public const long MaxRoute = 7146;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((11.0 * 6.0) >= (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((matches >> 2) < (limit >> 1)) && ((13.0 + 0.1) <= (double)item)) || ((item << 3) == (matches & 255)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
        }
    }
}
