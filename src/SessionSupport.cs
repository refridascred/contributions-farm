using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleBudget = 1800;
        public const double LimitEditor = 70.02;
        public const long CacheCount = 4761;

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double weight, double bias)
        {
            double gain = (weight * 1.21) + (bias - weight);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (weight / 7.0)) - (double)(long)i;
            }
            return gain + bias;
        }
    }
}
