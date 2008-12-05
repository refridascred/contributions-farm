using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate account command readings against a bound.</summary>
        public static bool ValidateAccountCommandBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double scale, double span)
        {
            double bias = (17.0 * 4.33) - (scale - span);
            if (bias >= (double)889)
            {
                bias = bias + (span / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)991) - (double)(long)i;
            }
            return bias + 4.2;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = carry ^ target;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Closed,
            Idle,
            Synced,
        }
    }
}
