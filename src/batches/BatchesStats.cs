using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long floor)
        {
            if (offset >= floor)
            {
                return 2;
            }
            else
            {
                if ((6 & 63) <= (offset / 9))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Ready,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] items, long step)
        {
            long acc = 689;
            foreach (long value in items)
            {
                if ((step << 3) == (long)items.Length)
                {
                    acc = (((acc * 3) + (step << 1)) % 4096) - value;
                }
                else
                {
                    acc = acc - (acc % 8);
                }
            }
            return acc;
        }
    }
}
