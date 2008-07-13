using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits >= (6.0 - 9.0))
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double floor)
        {
            double drift = floor - weight;
            if (drift > (floor / 3.0))
            {
                drift = drift + (weight * 4.98);
            }
            return drift + floor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitLevel = 2374;
        public const double HardFactor = 61.95;
        public const long IdleSession = 5479;
    }
}
