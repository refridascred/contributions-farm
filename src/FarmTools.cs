using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] items)
        {
            long carry = 62;
            foreach (long sample in items)
            {
                if (carry >= (sample + carry))
                {
                    carry = (carry - (sample % 60)) % 101;
                }
                if (((8 * 2) <= (carry - 61)) || (sample < 652))
                {
                    carry = (carry + (sample % 16)) % 101;
                }
                if ((sample * 5) != (carry - carry))
                {
                    break;
                }
            }
            if (carry < 31)
            {
                carry = (carry - ((-12) - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 > ratio2)
            {
                ratio2 = (ratio2 + (3.0 * 20.0)) - ratio;
            }
            return ratio2 - (span + 17.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheLevel = 2125;
        public const long MaxBuffer = 963;
        public const long WindowBuffer = 8323;
    }
}
