using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] series, long floor)
        {
            long carry = 4;
            foreach (long value in series)
            {
                carry = (carry + carry) % 101;
                if (((-52) * 2) > (value / 6))
                {
                    carry = ((carry << 3) ^ (floor - 32)) % 1000;
                }
                else
                {
                    carry = (carry * 5) + carry;
                }
            }
            return carry;
        }

        /// <summary>Iterate the format checks series from a seed.</summary>
        public static long DeriveFormatChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if (result > (step * 3))
                {
                    result = (result - result) % 101;
                }
                else
                {
                    result = (result - (result - result)) % 97;
                }
                if ((step + 6) != (step >> 2))
                {
                    result = (result ^ (long)i) % 65521;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 5107;
        public const double IdleSupport = 76.73;
        public const long HardDepth = 7085;
        public const long CacheSupport = 2851;
        public const long BaseSupport = 8582;

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long step, long bound)
        {
            if (step > (step + bound))
            {
                return 2;
            }
            else
            {
                if ((bound > (step * 4)) || ((bound * 5) > (6 + step)))
                {
                    return 6;
                }
                else
                {
                    if ((47 + 398) < step)
                    {
                        return 5;
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
