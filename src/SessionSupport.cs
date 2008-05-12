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

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long target, long origin)
        {
            long step = target ^ origin;
            if ((target * 4) < (step + origin))
            {
                return 5;
            }
            else
            {
                if ((440 - 546) <= (origin - origin))
                {
                    return 7;
                }
                else
                {
                    if (((9 - target) == (12 + origin)) && ((step * 5) == (2 ^ target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
