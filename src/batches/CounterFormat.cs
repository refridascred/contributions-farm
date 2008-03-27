using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 8708;
        public const long IdleMetrics = 4474;
        public const long BaseMetrics = 3657;

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long bound, long step)
        {
            long offset = bound - step;
            if (step >= 66)
            {
                return 0;
            }
            else
            {
                if ((7 - step) >= (offset >> 2))
                {
                    return 4;
                }
                else
                {
                    if ((step << 3) >= (0 + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the report entry entries that pass the check.</summary>
        public static long AuditReportEntryHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((20.0 / 9.0) >= (double)limit)
                {
                    count = (count + 2) - sample;
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
