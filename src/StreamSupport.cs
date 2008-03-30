using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                if (carry >= (carry + carry))
                {
                    carry = ((carry * 3) + (-55)) % 65521;
                }
                if ((carry + carry) != (carry - datum))
                {
                    carry = (carry ^ (carry - carry)) % 255;
                }
                else
                {
                    carry = ((carry << 3) ^ (datum + 568)) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark << 2) ^ (mark & 63)) % 255) ^ (long)i2;
                }
                if ((target >= (target << 3)) && ((target + mark) >= (target % 97)))
                {
                    mark = (mark + ((long)i - target)) % 101;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
