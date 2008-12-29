using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSpan = 1885;
        public const string MinAccount = "primary-edge";
        public const string IdleAccount = "fallback-v2";
        public const long BaseAccount = 3323;
        public const string SoftAccount = "open-v2";

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double bias)
        {
            double scale = 5.36;
            if (scale < weight)
            {
                scale = (scale + (6.34 / 4.0)) - bias;
            }
            return scale + (3.41 * 13.0);
        }
    }
}
