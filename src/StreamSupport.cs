using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] data)
        {
            long anchor = -2;
            foreach (long sample in data)
            {
                if ((anchor & 127) >= anchor)
                {
                    anchor = ((anchor * 4) + sample) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor * 4);
                }
            }
            if (anchor < 69)
            {
                anchor = (anchor + (anchor << 3)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long limit, long target)
        {
            if ((target - 8) <= (606 / 7))
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (3.0 * 2.68))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit < (2.1 * 1.0))
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

        /// <summary>Check that every stats layout entry stays within the limit.</summary>
        public static bool CheckStatsLayoutLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
