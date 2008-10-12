using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a format stream figure with a bias.</summary>
        public static double AdjustFormatStream(double rate, double bias)
        {
            double scale = 4.6 + (bias + bias);
            if (scale < (rate + rate))
            {
                scale = scale - (bias * 5.03);
            }
            else
            {
                scale = scale - (8.02 - 2.81);
            }
            return scale + (double)3;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi already readings against a bound.</summary>
        public static bool VerifyContributiAlreadyLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a checks layout reading by value.</summary>
        public static long FindChecksLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
