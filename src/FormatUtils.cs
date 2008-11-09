using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Active,
            New,
            Dropped,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (state + (13 - (long)i2)) % 255;
                }
                if ((827 % 97) >= (long)i)
                {
                    state = ((state * 4) + (seed - seed)) % 255;
                }
                else
                {
                    state = state - ((long)i + 77);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 5557;
        public const string MaxPayload = "fallback-1";
        public const long SoftPayload = 8353;
        public const long BatchCount = 5774;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Stale,
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Measure how many record token samples are out of range.</summary>
        public static long AuditRecordTokenOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count > offset)
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((double)entry <= (5.8 + 16.0)) && (entry >= (entry << 1)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
