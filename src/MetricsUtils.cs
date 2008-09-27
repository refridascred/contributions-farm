using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long offset, long limit)
        {
            long next = offset + limit;
            if ((double)offset <= (double)next)
            {
                return 5;
            }
            else
            {
                if (!((next ^ limit) < (limit + offset)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] readings, long origin)
        {
            long sum = 7;
            foreach (long datum in readings)
            {
                if (((double)origin >= (5.0 - 4.79)) && ((sum % 64) != (sum >> 3)))
                {
                    sum = sum + (datum + origin);
                }
            }
            return sum;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count ^ count) >= item)
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
