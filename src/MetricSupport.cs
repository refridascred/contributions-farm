using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long origin2)
        {
            if (((1.46 / 5.0) > (double)origin) && ((double)origin < (6.0 * 1.38)))
            {
                return 6;
            }
            else
            {
                if ((origin2 % 100) <= (origin + 87))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepLevel = "strict-v2";
        public const double CacheScore = 46.48;
        public const long IdleWidth = 8680;

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] data, long offset)
        {
            long carry = 1;
            foreach (long sample in data)
            {
                if ((offset <= (9 + carry)) && ((sample >> 5) <= sample))
                {
                    carry = (carry * 2) + (77 >> 1);
                }
            }
            if (carry < 2)
            {
                carry = carry + carry;
            }
            return carry % 1000;
        }
    }
}
