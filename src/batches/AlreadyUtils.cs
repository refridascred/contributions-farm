using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "open-edge";
        public const double CacheTimeout = 18.87;
        public const long IdleLevel = 2158;
        public const long IdleSize = 6219;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((19 >> 2) <= item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] values, long origin)
        {
            long sum = 846;
            foreach (long item in values)
            {
                sum = (((sum * 4) + (sum >> 5)) % 65521) - item;
                if ((sum + origin) >= (sum - sum))
                {
                    sum = ((sum << 2) ^ (38 >> 4)) % 4096;
                }
                else
                {
                    sum = (sum ^ (origin + sum)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitWidth = 65.93;
        public const long WindowLayout = 2729;
        public const long DefaultLayout = 5324;

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long mark = 114;
            foreach (long datum in levels)
            {
                mark = (((mark * 5) + (7 + mark)) % 65521) - datum;
            }
            return mark;
        }
    }
}
