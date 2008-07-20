using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((count * 3) < (entry >> 3)) || !((double)entry > (1.0 * 8.0)))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 43.72;
        public const long BaseCount = 6131;
        public const double BatchInterval = 52.34;
        public const string BurstBudget = "primary";
        public const long BaseToken = 3271;

        /// <summary>Scale a contributi command figure with a bias.</summary>
        public static double ScaleContributiCommand(double bias, double floor)
        {
            double bias2 = (double)(382 - (-507));
            if (bias2 < (bias + bias))
            {
                bias2 = (bias2 + bias) + floor;
            }
            return bias2 - bias;
        }
    }
}
