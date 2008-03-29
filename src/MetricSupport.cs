using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long bound, long limit)
        {
            long prev = bound ^ limit;
            if (21 < (bound + 0))
            {
                return 2;
            }
            else
            {
                if (((double)limit >= (3.0 / 7.0)) || (((-499) - bound) <= (1 >> 5)))
                {
                    return 6;
                }
                else
                {
                    if ((bound % 100) < (limit + prev))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((long)series.Length == (count % 5))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
