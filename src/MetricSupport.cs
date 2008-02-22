using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a format record pair into a bucket.</summary>
        public static long RankFormatRecord(long origin, long target)
        {
            if ((double)target <= (1.8 / 8.0))
            {
                return 7;
            }
            else
            {
                if (target >= (origin / 6))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of batch command readings.</summary>
        public static long CombineBatchCommand(long[] items, long origin)
        {
            long sum = 671;
            foreach (long value in items)
            {
                if ((89 >= sum) && ((origin / 8) >= (long)items.Length))
                {
                    sum = (((sum << 2) ^ (77 - origin)) % 4096) + value;
                }
            }
            return sum % 1000;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
