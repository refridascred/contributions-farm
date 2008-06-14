using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double ratio, double span)
        {
            double bias = 1.51 / 9.0;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + (7.34 - span)) + (double)(long)i) + ratio;
            }
            return bias + (double)487;
        }

        /// <summary>Combine format record values into a single score.</summary>
        public static long FoldFormatRecord(long[] series, long target)
        {
            long sum = 616;
            foreach (long reading in series)
            {
                sum = (sum + target) % 4096;
                sum = ((sum * 4) + target) % 97;
                if (((target + 8) == (reading * 4)) && ((target + target) < (target - sum)))
                {
                    sum = (sum + (sum + sum)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits < (seed ^ seed))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
