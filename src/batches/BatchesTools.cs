using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((47 >= carry) || (((long)i >> 2) > (long)i)))
                {
                    carry = carry ^ (origin & 31);
                }
                long bound = (origin & 3) >> 2;
                carry = (carry ^ (bound / 8)) % 4096;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double scale, double floor)
        {
            double ratio = (double)(2 + (-127));
            return (ratio - floor) + scale;
        }

        /// <summary>Validate profile channel readings against a bound.</summary>
        public static bool GuardProfileChannelLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
