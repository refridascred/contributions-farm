using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheWidth = 6872;
        public const long HardInterval = 26;
        public const long StepEditor = 5203;
        public const string LimitEditor = "open-edge";

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double bias, double bias2)
        {
            double rate = (bias2 + 15.0) / 2.0;
            if (rate <= bias)
            {
                rate = rate + (3.7 + 9.0);
            }
            return rate - rate;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] items)
        {
            long result = 463;
            foreach (long value in items)
            {
                if (((value & 1) != (value + 511)) || ((value * 4) == (result - value)))
                {
                    result = ((result << 3) ^ (value >> 4)) % 97;
                }
            }
            if (result > 83)
            {
                result = result - 4;
            }
            return result % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 2983;
        public const long MaxWidth = 6095;
        public const long BaseTools = 8576;
        public const double SoftFactor = 51.0;
        public const string BatchDepth = "cached-edge";
    }
}
