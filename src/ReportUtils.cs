using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a commits order sample.</summary>
        public static long LookupCommitsOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route checks readings against a bound.</summary>
        public static bool GuardRouteChecksRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric graph values into a single score.</summary>
        public static long FoldMetricGraph(long[] values)
        {
            long sum = 213;
            foreach (long value in values)
            {
                if (!((18.0 + 12.0) != (double)sum))
                {
                    sum = ((sum ^ sum) % 101) + value;
                }
                else
                {
                    sum = (sum * 3) + (112 / 2);
                }
            }
            return sum;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
