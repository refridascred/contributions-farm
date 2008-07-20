using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((82 + origin) >= (matches / 3))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Roll a metric context counter forward.</summary>
        public static long StepMetricContext(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = total + (bound / 3);
                total = total ^ (total / 8);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double ratio, double floor)
        {
            double weight = floor;
            if (weight > ratio)
            {
                weight = weight + (double)6;
            }
            else
            {
                weight = weight - (weight / 8.0);
            }
            return weight - weight;
        }
    }
}
