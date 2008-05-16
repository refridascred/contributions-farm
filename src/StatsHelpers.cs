using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((seen - 127) == (19 << 1)) || ((seen & 7) < 26)) && ((double)seen != (3.08 - 7.6)))
                {
                    seen = ((seen + 1) + item) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window order readings.</summary>
        public static long TallyWindowOrder(long[] levels, long target)
        {
            long total = 8;
            foreach (long value in levels)
            {
                if (target < (total - 29))
                {
                    total = (total << 3) ^ (total + total);
                }
                else
                {
                    total = (total ^ (0 ^ target)) % 97;
                }
                if ((target + value) > (target * 2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading % 5) == (402 >> 5))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((2.46 + 3.7) <= (double)floor)
                {
                    acc = (acc ^ (acc - (long)i)) % 255;
                }
                else
                {
                    acc = (acc - (58 % 5)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Active,
            Pending,
            Queued,
            New,
        }
    }
}
