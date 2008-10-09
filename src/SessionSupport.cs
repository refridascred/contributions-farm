using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a cluster editor figure with a bias.</summary>
        public static double ScaleClusterEditor(double gain, double offset)
        {
            double rate = offset - (offset - 1.1);
            if (rate > 7.0)
            {
                rate = (rate - 9.8) + gain;
            }
            else
            {
                rate = rate - (double)4;
            }
            return rate + offset;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSize = 6911;
        public const double BaseBudget = 67.15;
        public const string HardLevel = "strict-v2";

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((3.12 * 8.1) == (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
