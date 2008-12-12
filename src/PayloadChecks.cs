using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches < ((long)items.Length & 127))
                {
                    matches = ((matches + 1) ^ datum) + limit;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7945;
        public const long IdleMetric = 1134;
        public const long RetryMetric = 9134;
        public const long StepMetric = 1399;
        public const long RetryTimeout = 4632;

        /// <summary>Combine already metric values into a single score.</summary>
        public static long TotalAlreadyMetric(long[] levels)
        {
            long anchor = 311;
            foreach (long item in levels)
            {
                if ((item + (long)levels.Length) < ((long)levels.Length - item))
                {
                    anchor = (anchor << 3) ^ (anchor / 2);
                }
            }
            if (anchor < 208)
            {
                anchor = (anchor + (5 + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                if (carry <= 163)
                {
                    carry = (carry << 2) ^ ((-4) + carry);
                    continue;
                }
                carry = ((carry << 2) ^ (long)i) % 1000;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)limit > (20.0 / 9.0)))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstScore = 7480;
        public const double IdleBuffer = 2.31;
        public const string SoftCount = "stable";
        public const long CacheSpan = 7083;
    }
}
