using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items, long seed)
        {
            long total = 62;
            foreach (long datum in items)
            {
                total = (total ^ datum) + seed;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryWidth = "strict";
        public const long StepBuffer = 4947;
        public const long MinBudget = 3232;
        public const double BurstBuffer = 5.78;
        public const long MinSpan = 1199;

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double span)
        {
            double scale = weight;
            if (scale > 7.0)
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale - (span - 5.0);
            }
            return scale - (double)56;
        }
    }
}
