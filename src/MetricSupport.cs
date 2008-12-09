using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] series, long target)
        {
            long carry = 45;
            foreach (long datum in series)
            {
                if (datum < (carry + carry))
                {
                    carry = (carry ^ carry) % 65521;
                }
                else
                {
                    long matches = carry * 3;
                    carry = carry ^ (matches + 187);
                }
                carry = ((carry << 3) ^ (target - target)) % 1000;
                carry = carry - (target % 60);
            }
            return carry;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples)
        {
            long total = -361;
            foreach (long cell in samples)
            {
                if (cell >= total)
                {
                    total = (total * 2) + (638 * 3);
                }
                else
                {
                    total = (total ^ total) % 101;
                }
                if (!((double)74 <= (double)cell))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long step)
        {
            if (!(53 >= origin))
            {
                return 8;
            }
            else
            {
                if ((16.0 / 6.0) == (double)step)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
