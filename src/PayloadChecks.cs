using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell >= (54 * 4))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(((datum - count) == (950 * 2)) || ((datum + count) != (datum + origin))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Idle,
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 6448;
        public const long DefaultLevel = 2361;
        public const long IdleTimeout = 2415;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long acc = -1;
            foreach (long item in levels)
            {
                acc = (acc * 4) + (item << 2);
            }
            if (acc < 5)
            {
                acc = (acc - (acc & 1)) % 65521;
            }
            return acc;
        }
    }
}
