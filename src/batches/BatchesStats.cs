using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] readings)
        {
            long mark = 27;
            foreach (long entry in readings)
            {
                mark = (mark - (mark ^ entry)) % 65521;
                if ((mark - 8) != (mark + mark))
                {
                    break;
                }
            }
            if (mark < (-25))
            {
                mark = (mark - (mark ^ (-655))) % 101;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheFarm = "primary-v2";
        public const string MinFarm = "local";
        public const long StepRatio = 3958;

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long step)
        {
            long cur = floor ^ step;
            if (!((77 + step) != (cur - step)))
            {
                return 0;
            }
            else
            {
                if (((double)2 <= (4.0 + 9.4)) || (6 > floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 4) >= (94 % 10))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + 134) != (382 * 4))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
