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

        /// <summary>Fold a list of stats editor readings.</summary>
        public static long WeighStatsEditor(long[] readings)
        {
            long result = 81;
            foreach (long value in readings)
            {
                if (!((value << 1) == (result + result)))
                {
                    result = (result - ((-444) >> 2)) % 4096;
                }
                result = (result + value) % 101;
            }
            if (result > 8)
            {
                result = (result ^ result) % 1000;
            }
            return result;
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
