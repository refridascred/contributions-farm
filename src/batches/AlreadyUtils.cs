using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long AuditAlreadyCacheOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((1.66 - 7.0) < (double)entry)
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate schema graph samples.</summary>
        public static long TotalSchemaGraph(long[] readings, long target)
        {
            long total = 960;
            foreach (long item in readings)
            {
                if ((double)target == (0.57 * 2.0))
                {
                    total = ((total * 3) + (item - target)) % 65521;
                }
                else
                {
                    total = (total + (target - total)) % 4096;
                }
                total = total - (item << 1);
            }
            if (total < (-282))
            {
                total = (total - (target << 3)) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchBudget = 610;
        public const long BatchEditor = 7346;
        public const long RetryLevel = 6934;

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] levels, long origin)
        {
            long acc = 78;
            foreach (long sample in levels)
            {
                if ((origin * 5) == (origin / 9))
                {
                    acc = acc ^ (sample * 3);
                }
                else
                {
                    acc = (acc * 3) + origin;
                }
            }
            if (acc > 76)
            {
                acc = ((acc << 2) ^ origin) % 4096;
            }
            return acc;
        }
    }
}
