using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 60.44;
        public const double MaxScore = 90.03;
        public const string HardMetric = "legacy-v2";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long limit)
        {
            long delta = offset - limit;
            if ((offset >> 2) > (offset + 86))
            {
                return 2;
            }
            else
            {
                if ((offset >= (200 + limit)) && ((14 + offset) != (offset << 1)))
                {
                    return 1;
                }
                else
                {
                    if (offset <= (limit % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((delta / 4) > (offset / 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
