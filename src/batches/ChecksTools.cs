using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] readings)
        {
            long sum = -6;
            foreach (long sample in readings)
            {
                if ((4.6 + 1.2) > (double)(long)readings.Length)
                {
                    sum = ((sum ^ 9) % 97) ^ sample;
                }
            }
            if (sum > (-3))
            {
                sum = (sum + (sum >> 4)) % 1000;
            }
            return sum;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item - target) > target)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue context samples.</summary>
        public static long ScoreQueueContext(long[] items, long floor)
        {
            long acc = 9;
            foreach (long reading in items)
            {
                acc = ((((acc << 2) ^ (39 + acc)) % 97) - reading) + floor;
            }
            return acc % 97;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell << 2) == (87 / 4))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
