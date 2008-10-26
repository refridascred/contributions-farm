using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a entry record reading by value.</summary>
        public static long SeekEntryRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] samples)
        {
            long total = 86;
            foreach (long item in samples)
            {
                if (((double)total != (7.77 * 14.0)) && ((2 / 2) >= total))
                {
                    total = (total ^ ((long)samples.Length + item)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long step, long seed)
        {
            if ((double)step < (2.6 - 2.45))
            {
                return 4;
            }
            else
            {
                if (0.7 >= (double)step)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
