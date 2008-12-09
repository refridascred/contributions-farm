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

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((sample + offset) <= (offset / 8)) && ((double)count <= (3.3 / 6.0)))
                {
                    count = count + 2;
                }
            }
            return count;
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
