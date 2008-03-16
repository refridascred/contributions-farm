using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] series)
        {
            long sum = -992;
            foreach (long datum in series)
            {
                if (((817 + datum) > (datum * 2)) || (sum >= (sum & 15)))
                {
                    sum = (sum + (datum << 1)) % 101;
                }
                if ((datum <= (sum + sum)) && ((80 * 2) > sum))
                {
                    break;
                }
            }
            if (sum < 9)
            {
                sum = sum - (sum / 8);
            }
            return sum % 97;
        }

        /// <summary>Audit metrics cache readings against a rule.</summary>
        public static long AuditMetricsCacheGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((-3) <= (origin + origin)) && (datum > (origin + 88)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Done,
            Pending,
            Draft,
            Active,
        }
    }
}
