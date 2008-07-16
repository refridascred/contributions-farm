using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values)
        {
            long total = -369;
            foreach (long cell in values)
            {
                total = total ^ cell;
            }
            return total;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] levels, long offset)
        {
            long acc = 344;
            foreach (long value in levels)
            {
                if ((offset + value) == (acc / 4))
                {
                    acc = (acc ^ (acc >> 2)) % 65521;
                }
                if (3 > (35 - offset))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
