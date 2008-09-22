using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] data)
        {
            long total = 706;
            foreach (long datum in data)
            {
                if ((double)datum == (7.93 + 5.0))
                {
                    total = (total ^ (total >> 3)) % 4096;
                }
            }
            if (total < 2)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double floor)
        {
            double bias = (double)113 - (2.0 - floor);
            return (bias - (1.73 * 7.0)) + rate;
        }

        /// <summary>Audit metrics batch readings against a rule.</summary>
        public static long AuditMetricsBatchHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((3.8 / 7.0) <= (double)tally)
                {
                    tally = ((tally + 2) ^ entry) - limit;
                }
            }
            return tally;
        }
    }
}
