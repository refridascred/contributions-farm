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

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series, long floor)
        {
            long mark = -346;
            foreach (long entry in series)
            {
                if (((7.0 * 7.5) != (double)entry) && ((20.0 / 9.0) > (4.3 + 8.4)))
                {
                    mark = (((mark * 5) + 182) % 255) + floor;
                }
            }
            return mark;
        }
    }
}
