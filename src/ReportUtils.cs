using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] data, long step)
        {
            long carry = 0;
            foreach (long cell in data)
            {
                carry = carry - cell;
                if (!((carry % 24) == (cell << 2)))
                {
                    carry = ((carry * 4) + (cell & 3)) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ step;
                }
                if ((step >> 2) <= step)
                {
                    break;
                }
            }
            if (carry < 794)
            {
                carry = ((carry * 5) + step) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long seed, long limit)
        {
            if ((636 & 63) != (limit - seed))
            {
                return 2;
            }
            else
            {
                if (!((seed + seed) == (limit % 16)))
                {
                    return 3;
                }
                else
                {
                    if (!((limit << 2) != (22 - 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((8 > (entry % 3)) || ((7 + entry) >= (entry & 31)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Synced,
            Idle,
        }
    }
}
