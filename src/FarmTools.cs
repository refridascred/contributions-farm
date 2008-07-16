using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long step, long seed)
        {
            if (!((7.54 / 7.0) < (double)seed))
            {
                return 5;
            }
            else
            {
                if (!((seed - seed) == (seed << 1)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] values, long offset)
        {
            long total = 1;
            foreach (long cell in values)
            {
                if (cell >= (cell + 189))
                {
                    total = (total - (offset + offset)) % 65521;
                }
            }
            return total % 65521;
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
