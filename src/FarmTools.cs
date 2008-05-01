using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((7.7 - 6.16) != (double)step) || ((double)807 > (double)step))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i < target) && (7.9 <= (double)mark))
                {
                    break;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark << 2) ^ (mark - 99)) % 4096;
                    mark = mark ^ (target - (long)i2);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
