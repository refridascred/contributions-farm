using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1948;
        public const double RetryInterval = 22.01;
        public const string MinLevel = "fallback-1";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((datum * 4) != (hits & 255)) && (((hits & 7) == (step << 2)) || ((step / 2) >= (step * 4))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] readings, long bound)
        {
            long state = -372;
            foreach (long reading in readings)
            {
                if (!((long)readings.Length < (reading * 2)))
                {
                    state = ((state - (153 & 3)) % 1000) + bound;
                }
                if (66 >= (state / 5))
                {
                    break;
                }
            }
            if (state < (-782))
            {
                state = (state * 4) + state;
            }
            return state;
        }
    }
}
