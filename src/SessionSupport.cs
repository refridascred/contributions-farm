using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items, long floor)
        {
            long result = 256;
            foreach (long reading in items)
            {
                result = ((result ^ (floor ^ result)) % 4096) + reading;
            }
            if (result > 10)
            {
                result = result - (floor / 4);
            }
            return result;
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
