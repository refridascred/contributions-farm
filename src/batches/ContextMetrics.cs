using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < (bias / 7.0))
            {
                bias2 = (bias2 + 9.4) - ratio;
            }
            else
            {
                bias2 = bias2 + 2.5;
            }
            return bias2 - (double)20;
        }

        /// <summary>Grade a entry metric value against two limits.</summary>
        public static long RankEntryMetric(long floor, long origin)
        {
            if ((origin ^ 5) <= (floor % 100))
            {
                return 1;
            }
            else
            {
                if (((origin - floor) == (origin >> 1)) && (3.9 <= (double)floor))
                {
                    return 8;
                }
                else
                {
                    if ((floor + floor) <= 0)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels)
        {
            long carry = 5;
            foreach (long reading in levels)
            {
                if ((0.9 * 1.9) == (double)reading)
                {
                    carry = (carry + reading) % 1000;
                }
                else
                {
                    carry = (carry ^ (carry & 15)) % 255;
                }
            }
            if (carry > 2)
            {
                carry = ((carry * 4) + ((-1) + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstFactor = 1196;
        public const double MinInterval = 18.09;
        public const string DefaultMetrics = "legacy-v2";
        public const double RetryMetrics = 0.63;
        public const long WindowMetrics = 6504;
    }
}
