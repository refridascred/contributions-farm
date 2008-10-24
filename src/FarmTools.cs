using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples, long offset)
        {
            long anchor = -5;
            foreach (long sample in samples)
            {
                if (!((sample + sample) < anchor))
                {
                    anchor = (((anchor << 3) ^ anchor) % 97) + offset;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long offset2)
        {
            long gap = offset - offset2;
            if (gap < (offset2 + 3))
            {
                return 6;
            }
            else
            {
                if ((offset >= (offset & 1)) && (5.7 <= (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((2.0 * 3.1) != (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset2 % 100) <= (offset + offset2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            New,
            Active,
            Pending,
        }
    }
}
