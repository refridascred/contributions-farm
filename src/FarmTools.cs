using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 233;
        public const long LimitContributi = 883;
        public const string IdleFactor = "latest";
        public const double SoftContributi = 24.44;

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a order support figure with a bias.</summary>
        public static double SmoothOrderSupport(double bias, double floor)
        {
            double load = (double)4;
            return ((load + 14.0) + bias) + floor;
        }
    }
}
