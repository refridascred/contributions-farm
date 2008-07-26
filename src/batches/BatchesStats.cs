using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long target)
        {
            if (target > (target - target))
            {
                return 2;
            }
            else
            {
                if ((double)floor < 9.0)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the buffer format series from a seed.</summary>
        public static long RollBufferFormat(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                mark = mark - mark;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowScore = 65;
        public const long HardMetrics = 2698;
        public const long SoftSpan = 3408;
        public const long LimitBudget = 8350;

        /// <summary>Measure how many queue channel samples are out of range.</summary>
        public static long CountQueueChannelOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)offset >= 6.61)
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
