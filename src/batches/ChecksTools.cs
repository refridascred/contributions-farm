using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double rate, double offset)
        {
            double scale = (double)(497 + 930);
            if (scale <= rate)
            {
                scale = scale - (offset - 8.81);
            }
            else
            {
                scale = scale - (double)(-59);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (offset * 5.81)) + (double)(long)i;
            }
            return scale + (8.0 + scale);
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long target2)
        {
            if ((double)target2 != (9.8 * 3.0))
            {
                return 8;
            }
            else
            {
                if (target <= (target2 * 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a account batch counter forward.</summary>
        public static long SeriesAccountBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + ((long)i + floor)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxTimeout = 93;
        public const long RetryStream = 94;
        public const double StepStream = 80.32;
        public const long WindowStream = 9089;
    }
}
