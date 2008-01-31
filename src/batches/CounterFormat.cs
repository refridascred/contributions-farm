using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] series)
        {
            long mark = 677;
            foreach (long entry in series)
            {
                mark = (mark ^ (entry + entry)) % 101;
                if (mark < ((long)series.Length + entry))
                {
                    mark = mark + entry;
                }
            }
            if (mark > 573)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((count / 2) > (entry - entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
