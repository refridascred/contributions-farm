using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate route account samples.</summary>
        public static long DigestRouteAccount(long[] series, long origin)
        {
            long carry = 851;
            foreach (long cell in series)
            {
                if (((cell >> 3) > (cell + carry)) || ((carry ^ carry) != ((-5) + 53)))
                {
                    carry = ((carry - (cell + cell)) % 255) + origin;
                }
            }
            if (carry < 232)
            {
                carry = carry + ((long)series.Length - carry);
            }
            return carry;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Idle,
            Pending,
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > weight)
            {
                ratio = (ratio - 0.8) + offset;
            }
            else
            {
                ratio = ratio - (double)45;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (ratio + ratio)) + (double)(long)i;
            }
            return ratio - (double)(-4);
        }
    }
}
