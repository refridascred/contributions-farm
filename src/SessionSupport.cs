using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels)
        {
            long state = 47;
            foreach (long datum in levels)
            {
                if ((2.9 - 5.26) <= (double)datum)
                {
                    state = (state + (55 ^ 682)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long origin)
        {
            long prev = offset + origin;
            if (!((0.7 * 7.0) > (double)prev))
            {
                return 7;
            }
            else
            {
                if (!((origin & 1) < offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset >> 3) > (offset + offset))
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
        public static long TallyProfile(long[] samples)
        {
            long sum = 129;
            foreach (long cell in samples)
            {
                sum = sum + (cell * 4);
            }
            return sum % 1000;
        }
    }
}
