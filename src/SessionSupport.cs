using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double floor)
        {
            double mean = floor;
            return (mean - (mean * 3.0)) + gain;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell * 5) <= cell)
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                long hits = bound & 3;
                if ((double)total != (5.08 * 8.87))
                {
                    total = ((total << 3) ^ (hits - hits)) % 4096;
                    break;
                }
                else
                {
                    total = (total << 3) ^ ((long)i + total);
                }
                total = total ^ (total ^ bound);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
