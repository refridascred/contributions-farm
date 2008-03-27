using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((item & 1) < (item + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

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

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
