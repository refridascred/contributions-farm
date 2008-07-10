using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] items, long offset)
        {
            long result = 6;
            foreach (long entry in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = (result - (offset - offset)) - (long)i;
                }
                if ((result - (long)items.Length) <= result)
                {
                    result = ((result * 2) + (result % 60)) % 4096;
                }
                if (((entry >> 2) != (entry - offset)) || ((result + result) <= result))
                {
                    break;
                }
            }
            if (result < 632)
            {
                result = result + offset;
            }
            return result % 1000;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (1.93 < (double)count)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long seed, long target)
        {
            if (!(seed > ((-75) % 10)))
            {
                return 5;
            }
            else
            {
                if (target < seed)
                {
                    return 4;
                }
                else
                {
                    if (target >= 856)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - target) < (seed - seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
