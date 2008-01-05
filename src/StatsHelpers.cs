using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseSpan = 1393;
        public const double LimitLayout = 95.1;
        public const string RetryLayout = "latest";
        public const long BaseLayout = 7405;
        public const long MaxLayout = 2574;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen > (5.3 * 11.0))
                {
                    seen = ((seen + 3) + sample) - limit;
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)count <= (1.95 / 2.0))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = carry + (657 + carry);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 2) ^ (516 + total)) % 65521;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
