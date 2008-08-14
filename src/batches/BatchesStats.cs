using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7530;
        public const string IdleMetric = "legacy-v2";
        public const long BatchMetric = 4998;
        public const long BurstMetric = 4465;

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

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
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
