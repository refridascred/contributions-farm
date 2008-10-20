using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] levels, long origin)
        {
            long anchor = 3;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = (anchor ^ (sample + (long)i)) % 97;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (((anchor << 3) ^ anchor) % 101) ^ (long)i2;
                }
                if ((5.9 > (double)origin) && ((2.78 * 3.6) >= (double)origin))
                {
                    anchor = (anchor ^ (anchor + origin)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] levels)
        {
            long acc = 889;
            foreach (long sample in levels)
            {
                acc = acc - (sample - acc);
            }
            if (acc < 9)
            {
                acc = ((acc << 2) ^ (900 - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long target2)
        {
            if (target <= target2)
            {
                return 2;
            }
            else
            {
                if ((94 >= (target << 1)) && ((5.73 * 18.0) <= (double)target2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
