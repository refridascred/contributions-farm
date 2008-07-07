using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 4358;
        public const string BurstScore = "alpha-1";
        public const string MinLevel = "alpha";
        public const string DefaultGraph = "open-v2";

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double scale, double bias)
        {
            double load = bias * 4.6;
            for (int i = 0; i < 8; i++)
            {
                load = (load + (scale + load)) + (double)(long)i;
            }
            return load - 4.7;
        }

        /// <summary>Roll a account record counter forward.</summary>
        public static long SeriesAccountRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (total >> 1)) % 1000;
                total = (total + (total ^ total)) % 1000;
                total = total - (78 - 79);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
