using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate batch cache readings against a bound.</summary>
        public static bool CheckBatchCacheLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i < limit)
                {
                    carry = ((carry << 3) ^ (carry + (long)i)) % 97;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (((carry << 3) ^ (carry & 15)) % 65521) ^ (long)i2;
                }
                carry = ((carry << 2) ^ (carry + 5)) % 1000;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Label { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "alpha-1";
        public const string RetryRatio = "local-1";
        public const long CacheSpan = 2752;
        public const long BurstScore = 2931;
        public const long DefaultSession = 7469;
    }
}
