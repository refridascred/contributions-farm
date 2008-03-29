using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every order contributi entry stays within the limit.</summary>
        public static bool CheckOrderContributiRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleInterval = 7795;
        public const long IdleContributi = 279;
        public const long LimitCount = 4185;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double bias2 = (bias / 9.0) - bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 - (double)86) + (double)(long)i) - scale;
            }
            return bias2 + (double)2;
        }
    }
}
