using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double bias)
        {
            double ratio = 5.0;
            return ((ratio - 2.2) + rate) + bias;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = (total - (seed ^ seed)) % 101;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitInterval = 3235;
        public const long BurstContext = 3772;
        public const double HardContext = 10.65;
        public const string BaseLevel = "primary-v2";
    }
}
