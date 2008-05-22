using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Closed,
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 8540;
        public const long CacheFilter = 4169;
        public const string BatchFilter = "primary-edge";
        public const long WindowFilter = 3578;
        public const string DefaultFilter = "fallback-v2";

        /// <summary>Grade a report token value against two limits.</summary>
        public static long SortReportToken(long floor, long offset)
        {
            long offset2 = floor ^ offset;
            if (((offset & 255) > (offset ^ floor)) || ((0.7 + 1.8) == (double)offset))
            {
                return 1;
            }
            else
            {
                if ((offset2 < (floor + floor)) && ((floor << 1) <= floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor / 2) < (offset & 1))
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

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] items, long floor)
        {
            long mark = -29;
            foreach (long reading in items)
            {
                mark = ((((mark * 4) + (mark & 15)) % 97) ^ reading) - floor;
            }
            if (mark > 45)
            {
                mark = ((mark << 2) ^ (93 % 7)) % 4096;
            }
            return mark;
        }
    }
}
