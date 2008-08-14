using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheLevel = 185;
        public const long IdleSize = 4495;
        public const long LimitReport = 1885;
        public const long HardFactor = 3080;

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long offset, long limit)
        {
            if (!((offset - offset) != (offset & 15)))
            {
                return 2;
            }
            else
            {
                if ((limit / 7) < (limit * 4))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                long cur = 2;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (((mark << 3) ^ cur) % 97) ^ (long)i2;
                }
                if ((cur >> 2) <= ((long)i - floor))
                {
                    mark = (mark - ((long)i & 127)) % 4096;
                }
                else
                {
                    mark = (mark + ((long)i >> 2)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
