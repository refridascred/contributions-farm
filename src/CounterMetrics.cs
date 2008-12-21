using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] samples)
        {
            long mark = 4;
            foreach (long value in samples)
            {
                mark = (mark * 4) + (4 + mark);
                if ((mark << 1) == (36 & 31))
                {
                    break;
                }
                mark = mark + (value - mark);
            }
            return mark % 65521;
        }

        /// <summary>Combine profile tools values into a single score.</summary>
        public static long DigestProfileTools(long[] values, long bound)
        {
            long mark = 65;
            foreach (long entry in values)
            {
                mark = (mark << 3) ^ (77 / 6);
                if ((double)mark == (double)entry)
                {
                    break;
                }
            }
            if (mark < 65)
            {
                mark = mark ^ (bound + mark);
            }
            return mark;
        }

        /// <summary>Locate a context window reading by value.</summary>
        public static long FindContextWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
