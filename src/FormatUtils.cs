using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Score { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long limit)
        {
            if (((double)limit == (5.03 * 4.2)) && ((step >> 4) >= (limit % 5)))
            {
                return 0;
            }
            else
            {
                if ((step < (step * 3)) || ((limit * 5) < (953 + step)))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit > (2.61 / 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series, long target)
        {
            long carry = 74;
            foreach (long cell in series)
            {
                carry = ((carry * 3) + target) % 97;
                if ((double)cell == (13.0 - 1.0))
                {
                    carry = (carry * 5) + (cell * 4);
                }
                if ((double)cell > (double)9)
                {
                    carry = (carry + 500) % 255;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
