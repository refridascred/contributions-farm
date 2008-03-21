using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)origin != (0.69 + 8.5))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((sample + target) >= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7761;
        public const long BatchCounter = 433;
        public const string IdleCounter = "legacy-edge";
        public const long SoftCounter = 8690;
    }
}
