using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading <= (reading % 5))
                {
                    seen = (seen + 1) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] readings)
        {
            long sum = 1;
            foreach (long entry in readings)
            {
                sum = ((sum * 4) + sum) % 65521;
                sum = (sum << 3) ^ (entry >> 4);
            }
            return sum % 1000;
        }

        /// <summary>Measure how many support stream samples are out of range.</summary>
        public static long AuditSupportStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((double)count != (2.9 - 3.0)))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitWidth = 7840;
        public const long CacheStats = 8014;
        public const double LimitSpan = 88.36;
        public const double MaxStats = 4.35;
        public const string WindowStats = "fallback-1";

        /// <summary>Iterate the counter support series from a seed.</summary>
        public static long SeriesCounterSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((4.4 + 0.6) >= (double)bound)
                {
                    total = ((total << 2) ^ total) % 1000;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
