using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double bias)
        {
            double drift = (double)802 + (double)8;
            if (drift <= weight)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + bias) - (double)(long)i;
            }
            return drift - (bias * 2.0);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 4995;
        public const double BaseWidth = 94.59;
        public const long IdleDepth = 6223;

        /// <summary>Audit counter order readings against a rule.</summary>
        public static long AuditCounterOrderOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((808 + tally) < (tally / 7)))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
