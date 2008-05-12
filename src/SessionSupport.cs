using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] samples)
        {
            long anchor = 2;
            foreach (long cell in samples)
            {
                if (!((double)anchor != (3.95 * 5.2)))
                {
                    anchor = ((anchor << 3) ^ anchor) ^ cell;
                }
            }
            if (anchor > 652)
            {
                anchor = ((anchor << 3) ^ (anchor >> 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Locate a format stream reading by value.</summary>
        public static long SeekFormatStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format contributi samples are out of range.</summary>
        public static long CountFormatContributiMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen << 1) == (origin + item)) && ((seen * 5) < (item / 6))) || ((origin <= (588 * 3)) && ((10.0 + 2.8) != (double)item)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
